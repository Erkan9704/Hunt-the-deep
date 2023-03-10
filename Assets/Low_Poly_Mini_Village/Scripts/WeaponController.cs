using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using static Models;

public class WeaponController : MonoBehaviour
{
    private Character_controller characterController;

    [Header("References")]
    public Animator weaponAnimator;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    [Header("Settings")]
    public WeaponSettingsModel settings;

    bool isInitialised;

    Vector3 newWeaponRotation;
    Vector3 newWeaponRoationVeclocity;
    
    Vector3 targetnewWeaponRotation;
    Vector3 targetnewWeaponRoationVeclocity;

    Vector3 newWeaponMovementRotation;
    Vector3 newWeaponMovementRoationVeclocity;

    Vector3 targetnewWeaponMovementRotation;
    Vector3 targetnewWeaponMovementRoationVeclocity;

    private bool isGroundedTrigger;

    private float fallingDelay;

    [Header("Weapon Sway")]
    public Transform weaponSwayObject;

    public float swayAmountA = 1;
    public float swayAmountB = 2;
    public float swayScale = 600;
    public float swayLepSpeed = 14;

    public float swayTime;
    public Vector3 swayPosition;

    

    [Header("Sights")]
    public Transform sightTarget;
    public float sightOffset;
    public float aimingInTime;
    private Vector3 weaponSwayPosition;
    private Vector3 weaponSwayPositionVelocity;
    public bool isAimingIn;
    public float AimingInBobbingAmount;

    [Header("Shooting")]
    public float ratOfFire;
    public float currentFireRate;
    public List<WeaponFireType> allowedFireTypes;
    public WeaponFireType currentFireType;
    public bool isShooting;

    private void Start()
    {
        newWeaponRotation = transform.localRotation.eulerAngles;

        currentFireType = allowedFireTypes.First();
    }


    public void Initialise(Character_controller CharacterController)
    {
        characterController = CharacterController;
        isInitialised = true;
    }


    private void Update()
    {
        if (!isInitialised)
        {
            return;
     
        }



        CalculateWeaponSway();
        CalculateWeaponRoation();
        SetWeaponAnimations();
        CalculateAimingIn();
        CalculateShooting();

        if (characterController.isGrounded && !isGroundedTrigger)
        {
            isGroundedTrigger = true;
        }
        else if (!characterController.isGrounded && isGroundedTrigger)
        {
            isGroundedTrigger = false;
        }

    }


    private void CalculateShooting()
    {
        if (isShooting)
        {
            Shoot();

            if(currentFireType == WeaponFireType.SemiAuto)
            {
                isShooting = false;
            }
        }
    }

    private void Shoot()
    {
        var bullet = Instantiate(bulletPrefab, bulletSpawn);




    }

    private void CalculateAimingIn()
    {
        var targetPosition = transform.position;

        if (isAimingIn)
        {
            targetPosition = characterController.Camera.transform.position + (weaponSwayObject.transform.position - sightTarget.position) + (characterController.Camera.transform.forward * sightOffset);
        }

        weaponSwayPosition = weaponSwayObject.transform.position;
        weaponSwayPosition = Vector3.SmoothDamp(weaponSwayPosition, targetPosition, ref weaponSwayPositionVelocity, aimingInTime);
        weaponSwayObject.transform.position = weaponSwayPosition + swayPosition;
    }

    public void TriggerJump()
    {
        isGroundedTrigger = false;

    }

    private void CalculateWeaponRoation()
    {
        weaponAnimator.speed = characterController.weaponAnimationSpeed;

        targetnewWeaponRotation.y += (isAimingIn ? settings.SwayAmount / 10 : settings.SwayAmount) * ((settings.SwayXinverted ? -characterController.input_View.x : characterController.input_View.x)) * Time.deltaTime;
        targetnewWeaponRotation.x += (isAimingIn ? settings.SwayAmount / 10 : settings.SwayAmount) * (settings.SwayYinverted ? characterController.input_View.y : -characterController.input_View.y) * Time.deltaTime;

        targetnewWeaponRotation.x = Mathf.Clamp(targetnewWeaponRotation.x, -settings.SwayClampX, settings.SwayClampX);
        targetnewWeaponRotation.y = Mathf.Clamp(targetnewWeaponRotation.y, -settings.SwayClampY, settings.SwayClampY);
        targetnewWeaponRotation.z = isAimingIn ? 0 : targetnewWeaponRotation.y ;

        targetnewWeaponRotation = Vector3.SmoothDamp(targetnewWeaponRotation, Vector3.zero, ref targetnewWeaponRoationVeclocity, settings.SwayResetSmoothing);
        newWeaponRotation = Vector3.SmoothDamp(newWeaponRotation, targetnewWeaponRotation, ref newWeaponRoationVeclocity, settings.SwaySmoothing);

        targetnewWeaponMovementRotation.z = (isAimingIn ? settings.MovementSwayX / 3 : settings.MovementSwayX)* (settings.MovementSwayXinverted ? -characterController.input_Movement.x : characterController.input_Movement.x);
        targetnewWeaponMovementRotation.x = (isAimingIn ? settings.MovementSwayY / 3 : settings.MovementSwayY) * (settings.MovementSwayYinverted ? -characterController.input_Movement.y : characterController.input_Movement.y);

        targetnewWeaponMovementRotation = Vector3.SmoothDamp(targetnewWeaponMovementRotation, Vector3.zero, ref targetnewWeaponMovementRoationVeclocity, settings.MovementSwaySmoothing);
        newWeaponMovementRotation = Vector3.SmoothDamp(newWeaponMovementRotation, targetnewWeaponRotation, ref newWeaponMovementRoationVeclocity, settings.MovementSwaySmoothing);

        transform.localRotation = Quaternion.Euler(newWeaponRotation + newWeaponMovementRotation);
    }

    private void SetWeaponAnimations()
    {
        weaponAnimator.SetBool("IsSprinting", characterController.isSprinting);
    }

    private void CalculateWeaponSway()
    {
        var targetPosition = LissajousCurve(swayTime, swayAmountA, swayAmountB) / (isAimingIn ? swayScale * AimingInBobbingAmount : swayScale);

        swayPosition = Vector3.Lerp(swayPosition, targetPosition,Time.smoothDeltaTime*swayLepSpeed);
        swayTime += Time.deltaTime;

        if (swayTime > 6.3f)
        {
            swayTime = 0;
        }



    }

    private Vector3 LissajousCurve(float Time, float A, float B)
    {
        return new Vector3(Mathf.Sin(Time), A * Mathf.Sin(B * Time + Mathf.PI));
    }

}
