using UnityEngine;
using static Models;

public class WeaponController : MonoBehaviour
{
    private Character_controller characterController;

    [Header("References")]
    public Animator weaponAnimator;

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

    private void Start()
    {
        newWeaponRotation = transform.localRotation.eulerAngles;
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




        CalculateWeaponRoation();
        SetWeaponAnimations();

        if (characterController.isGrounded && !isGroundedTrigger)
        {
            isGroundedTrigger = true;
        }
        else if (!characterController.isGrounded && isGroundedTrigger)
        {
            isGroundedTrigger = false;
        }

    }

    public void TriggerJump()
    {
        isGroundedTrigger = false;

    }

    private void CalculateWeaponRoation()
    {
        weaponAnimator.speed = characterController.weaponAnimationSpeed;

        targetnewWeaponRotation.y += settings.SwayAmount * ((settings.SwayXinverted ? -characterController.input_View.x : characterController.input_View.x)) * Time.deltaTime;
        targetnewWeaponRotation.x += settings.SwayAmount * (settings.SwayYinverted ? characterController.input_View.y : -characterController.input_View.y) * Time.deltaTime;

        targetnewWeaponRotation.x = Mathf.Clamp(targetnewWeaponRotation.x, -settings.SwayClampX, settings.SwayClampX);
        targetnewWeaponRotation.y = Mathf.Clamp(targetnewWeaponRotation.y, -settings.SwayClampY, settings.SwayClampY);
        targetnewWeaponRotation.z = targetnewWeaponRotation.y;

        targetnewWeaponRotation = Vector3.SmoothDamp(targetnewWeaponRotation, Vector3.zero, ref targetnewWeaponRoationVeclocity, settings.SwayResetSmoothing);
        newWeaponRotation = Vector3.SmoothDamp(newWeaponRotation, targetnewWeaponRotation, ref newWeaponRoationVeclocity, settings.SwaySmoothing);

        targetnewWeaponMovementRotation.z = settings.MovementSwayX * (settings.MovementSwayXinverted ? -characterController.input_Movement.x : characterController.input_Movement.x);
        targetnewWeaponMovementRotation.x = settings.MovementSwayY * (settings.MovementSwayYinverted ? -characterController.input_Movement.y : characterController.input_Movement.y);

        targetnewWeaponMovementRotation = Vector3.SmoothDamp(targetnewWeaponMovementRotation, Vector3.zero, ref targetnewWeaponMovementRoationVeclocity, settings.MovementSwaySmoothing);
        newWeaponMovementRotation = Vector3.SmoothDamp(newWeaponMovementRotation, targetnewWeaponRotation, ref newWeaponMovementRoationVeclocity, settings.MovementSwaySmoothing);

        transform.localRotation = Quaternion.Euler(newWeaponRotation + newWeaponMovementRotation);
    }

    private void SetWeaponAnimations()
    {
        weaponAnimator.SetBool("IsSprinting", characterController.isSprinting);
    }
}
