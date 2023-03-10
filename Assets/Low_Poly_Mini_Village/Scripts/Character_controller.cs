using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Models;

public class Character_controller : MonoBehaviour
{
    private CharacterController characterController;
    private Defaultinput defaultinput;
    public Vector2 input_Movement;
    public Vector2 input_View;

    private Vector2 newCameraRotation;
    private Vector3 newCharacterRotation;

    [Header("References")]
    public Transform CameraHolder;
    public Transform Camera;
    public Transform feetTransform;

    [Header("Settings")]
    public PlayerSettingsModel playerSettings;
    public float viewClampYMin = -70;
    public float viewClampYMax = 80;
    public LayerMask playerMask;
    public LayerMask groundMask;

    [Header("Gravity")]
    public float gravityAmount;
    public float gravityMin;
    public float playerGravity;
    
 

    public Vector3 jumpingForce;
    private Vector3 jumpingForceVelocity;
    
    [Header("Stance")]
    public PlayerStance playerStance;
    public float playerStanceSmoothing;
    public CharacterStance playerStandStance;
    public CharacterStance playerCrouchStance;
    public CharacterStance playerProneStance;
    private float stanceCheckErrorMargin = 0.05f;
    
    private float cameraHeight;
    private float cameraHeightVelocity;

    private Vector3 stanceCapsuleCenterVelocity;
    private float stanceCapsuleHeighVelocity;


    [HideInInspector]
    public bool isSprinting;

    private Vector3 newMovementSpeed;
    private Vector3 newMovementSpeedVelocity;



    [Header("Weapon")]
    public WeaponController currentWeapon;

    public float weaponAnimationSpeed;
    [HideInInspector]
    public bool isGrounded;
    [HideInInspector]
    public bool isFalling;

    [Header("Leaning")]
    public Transform LeanPivot;
    public float currentLean;
    public float targetLean;
    public float leanAngle;
    public float leanSmoothing;
    public float leanVelocity;

    private bool isLeaningLeft;
    private bool isLeaningRight;

    [Header("Aiming In")]
    public bool isAimingIn;

    private void Awake()
    {
        defaultinput = new Defaultinput();
        
        defaultinput.Character.Movement.performed += e => input_Movement = e.ReadValue<Vector2>();
        defaultinput.Character.View.performed += e => input_View = e.ReadValue<Vector2>();
        defaultinput.Character.Jump.performed += e => Jump();

        defaultinput.Character.Crouch.performed += e => Crouch();
        defaultinput.Character.Prone.performed += e => Prone();

        defaultinput.Character.Sprint.performed += e => ToggleSprint();
        defaultinput.Character.SprintReleased.performed += e => StopSprint();

        defaultinput.Weapon.Fire2Pressed.performed += e => AimingInPressed();
        defaultinput.Weapon.Fire2Released.performed += e => AimingInReleased();

        defaultinput.Character.LeanLeftPressed.performed += e => isLeaningLeft = true;
        defaultinput.Character.LeanLeftReleased.performed += e => isLeaningLeft = false;

        defaultinput.Character.LeanRightPressed.performed += e => isLeaningRight = true;
        defaultinput.Character.LeanRightReleased.performed += e => isLeaningRight = false;

        defaultinput.Weapon.Fire1Pressed.performed += e => ShootingPressed();
        defaultinput.Weapon.Fire1Released.performed += e => ShootingReleased();

        defaultinput.Enable();

        newCameraRotation = CameraHolder.localRotation.eulerAngles;
        newCharacterRotation = transform.localRotation.eulerAngles;

        characterController = GetComponent<CharacterController>();

        cameraHeight = CameraHolder.localPosition.y;

        if (currentWeapon)
        {
            currentWeapon.Initialise(this);
        }

    }

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        SetIsGrounded();
        SetIsFalling();
        CalculateView();
        CalculateMovement();
        CalculateJump();
        CalculateStance();
        CalculateLeaning();
        CalculateAimingIn();



    }

    private void ShootingPressed()
    {
        if (currentWeapon)
        {
            currentWeapon.isShooting = true;
        }
    }
    private void ShootingReleased()
    {
        if (currentWeapon)
        {
            currentWeapon.isShooting = false;
        }
    }

    private void AimingInPressed()
    {
        isAimingIn = true;
    }
    private void AimingInReleased()
    {
        isAimingIn = false;
    }

    private void CalculateAimingIn()
    {
        if (!currentWeapon)
        {
            return;
        }

        currentWeapon.isAimingIn = isAimingIn;
    }

    private void SetIsGrounded()
    {
        isGrounded = Physics.CheckSphere(feetTransform.position, playerSettings.isGroundedRadius, groundMask);
    }

    private void SetIsFalling()
    {
        isFalling = (!isGrounded && characterController.velocity.magnitude > playerSettings.isFallingSpeed);
        
    }

    private void CalculateView()
    {

        newCharacterRotation.y += (isAimingIn ? playerSettings.ViewXSensitivity * playerSettings.AimingSensitivityEffector : playerSettings.ViewXSensitivity) * ((playerSettings.ViewXInverted ? -input_View.x : input_View.x)) * Time.deltaTime;
        transform.localRotation = Quaternion. Euler(newCharacterRotation);



        newCameraRotation.x += (isAimingIn ? playerSettings.ViewYSensitivity *playerSettings.AimingSensitivityEffector : playerSettings.ViewYSensitivity) * (playerSettings.ViewYInverted ? input_View.y : -input_View.y) * Time.deltaTime;
        CameraHolder.localRotation = Quaternion.Euler(newCameraRotation);

        newCameraRotation.x = Mathf.Clamp(newCameraRotation.x, viewClampYMin, viewClampYMax);
    }
        
    private void CalculateMovement()
    {

        if (input_Movement.y <= 0.2f || isAimingIn == true || currentWeapon.isShooting == true)
        {
            isSprinting = false;
        }
        


        var verticalSpeed = playerSettings.WalkingForwardSpeed;
        var horizontalSpeed = playerSettings.WalkingStrafeSpeed;

        if (isSprinting)
        {
            verticalSpeed = playerSettings.RunningForwardSpeed;
            horizontalSpeed = playerSettings.RunningStrafeSpeed;
        }

        if (!isGrounded)
        {
            playerSettings.SpeedEffector = playerSettings.FallingSpeedEffector;

        }

        else if (playerStance == PlayerStance.Crouch)
        {
            playerSettings.SpeedEffector = playerSettings.CrouchSpeedEffector;
        }
        else if (playerStance == PlayerStance.Prone)
        {
            playerSettings.SpeedEffector = playerSettings.ProneSpeedEffector;

        }
        else if (isAimingIn)
        {
            playerSettings.SpeedEffector = playerSettings.AimingSpeedEffector;

        }

        else
        {
            playerSettings.SpeedEffector = 1;
        }

        weaponAnimationSpeed = characterController.velocity.magnitude/ (playerSettings.WalkingForwardSpeed * playerSettings.SpeedEffector);

        if (weaponAnimationSpeed > 1)
        {
            weaponAnimationSpeed = 1;
        }

        verticalSpeed *= playerSettings.SpeedEffector;
        horizontalSpeed *= playerSettings.SpeedEffector;



        newMovementSpeed = Vector3.SmoothDamp(newMovementSpeed, new Vector3(horizontalSpeed * input_Movement.x * Time.deltaTime, 0, verticalSpeed * input_Movement.y * Time.deltaTime), ref newMovementSpeedVelocity, isGrounded ? playerSettings.MovementSmoothing : playerSettings.FallingSmoothing);
        var movementSpeed = transform.TransformDirection(newMovementSpeed);

        if (playerGravity > gravityMin )
        {
            playerGravity -= gravityAmount * Time.deltaTime;
        }

        

        if (playerGravity < -0.1f && isGrounded)
        {
            playerGravity = -0.1f;
        }
        



        movementSpeed.y += playerGravity;

        movementSpeed += jumpingForce * Time.deltaTime;

        characterController.Move(movementSpeed);


    }
    


    private void CalculateLeaning()
    {
        if (isLeaningLeft)
        {
            targetLean = leanAngle;
        }
        else if (isLeaningRight)
        {
            targetLean = -leanAngle;
        }
        else
        {
            targetLean = 0;
        }



        currentLean = Mathf.SmoothDamp(currentLean, targetLean, ref leanVelocity, leanSmoothing);

        LeanPivot.localRotation = Quaternion.Euler(new Vector3(0,0,currentLean));
    }

    
    private void CalculateJump()
    {
        jumpingForce = Vector3.SmoothDamp(jumpingForce, Vector3.zero, ref jumpingForceVelocity, playerSettings.JumpingFalloff);
    }

    private void CalculateStance()
    {

        var currentStance = playerStandStance;

        if(playerStance==PlayerStance.Crouch)
        {
            currentStance = playerCrouchStance;
        }
        else if(playerStance == PlayerStance.Prone)
        {
            currentStance = playerProneStance;
        }


        cameraHeight = Mathf.SmoothDamp(CameraHolder.localPosition.y, currentStance.CameraHeight, ref cameraHeightVelocity, playerStanceSmoothing);

        CameraHolder.localPosition = new Vector3(CameraHolder.localPosition.x, cameraHeight, CameraHolder.localPosition.z);

        characterController.height = Mathf.SmoothDamp(characterController.height, currentStance.StanceCollider.height, ref stanceCapsuleHeighVelocity, playerStanceSmoothing);

        characterController.center = Vector3.SmoothDamp(characterController.center,currentStance.StanceCollider.center, ref stanceCapsuleCenterVelocity, playerStanceSmoothing);

    }

    private void Jump()
    {
        if(!isGrounded || playerStance == PlayerStance.Prone)
        {
            return;
        }
        if (playerStance == PlayerStance.Crouch)
        {
            if (StanceCheck(playerStandStance.StanceCollider.height))
            {
                return;
            }

            playerStance = PlayerStance.Stand;
            return;
        }



        jumpingForce = Vector3.up * playerSettings.JumpingHeight;
        playerGravity = 0;

        currentWeapon.TriggerJump();

    }

    private void Crouch()
    {
        if (playerStance == PlayerStance.Crouch)
        {

            if (StanceCheck(playerStandStance.StanceCollider.height))
            {
                return;
            }



            if (StanceCheck(playerCrouchStance.StanceCollider.height))
            {
                return;
            }

            playerStance = PlayerStance.Stand;
            return;
        }
        playerStance = PlayerStance.Crouch;
    }

    private void Prone()
    {
        playerStance = PlayerStance.Prone;
    }

    private bool StanceCheck(float stanceCheckheight)
    {

        var start = new Vector3(feetTransform.position.x,feetTransform.position.y + characterController.radius + stanceCheckErrorMargin , feetTransform.position.z);
        var end = new Vector3(feetTransform.position.x, feetTransform.position.y - characterController.radius - stanceCheckErrorMargin + stanceCheckheight, feetTransform.position.z);





        return Physics.CheckCapsule(start,end, characterController.radius, playerMask);
    }

    private void ToggleSprint()
    {
        if (input_Movement.y <= 0.2f)
        {
            isSprinting = false;
            return;
        }

        isSprinting = !isSprinting;
    }
    private void StopSprint()
    {
        if (playerSettings.SprintingHold)
        {
            isSprinting = false;
        }

        


    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(feetTransform.position, playerSettings.isGroundedRadius);
    }
}
