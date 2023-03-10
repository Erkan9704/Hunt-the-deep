//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Low_Poly_Mini_Village/Inputs/Defaultinput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Defaultinput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Defaultinput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Defaultinput"",
    ""maps"": [
        {
            ""name"": ""Character"",
            ""id"": ""2855848d-04b1-47ce-8978-bb2eb9705288"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""cf03da95-711e-42eb-81f8-c10f9e009293"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""View"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b5290ad9-a737-4c09-8168-2905c863f6ce"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""84164a31-299e-410e-aa50-1b10ebbee11c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""eea5d7cd-1a9b-409a-bbd0-26d3bb5adfbf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Prone"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4e36c6c9-586c-4466-b0ce-34248896db8c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""bf5749c3-0402-4ffd-b13c-0bdc33a309e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SprintReleased"",
                    ""type"": ""Button"",
                    ""id"": ""7f019d91-d654-4fcc-be0f-f6476aa02470"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeanLeftPressed"",
                    ""type"": ""Button"",
                    ""id"": ""73c98977-d6f4-4c2b-820e-c9a27ba44232"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeanRightPressed"",
                    ""type"": ""Button"",
                    ""id"": ""094f202c-31e1-4859-9e5c-4eff734279fc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeanLeftReleased"",
                    ""type"": ""Button"",
                    ""id"": ""d62a9e50-da0f-4d01-a119-0ac0aabd3b2d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeanRightReleased"",
                    ""type"": ""Button"",
                    ""id"": ""1f15b0b5-22bc-4f13-bca6-5a2c4eeb31e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6db28a4b-ce4d-4ec4-a105-456ffb438b79"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""View"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""47aab6aa-1d20-411b-8812-e48d01fe8d52"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""06d96584-67c1-4854-a612-911966694171"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cc8b30b8-f91f-4431-8a49-7a71347c911c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""73823709-5d90-43e2-9389-fccb7b0248e4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2a85f978-fd7d-459e-bb3c-162159db31cb"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""cb1180c7-f302-48d2-8247-51238adfd29e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d83ee158-46d2-4f61-bc70-7408bcd9e941"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa638b43-7421-4007-9299-772e14c67ba9"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Prone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a8d71ad-01df-4f1e-aa2b-c2e20c3c086f"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Prone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16d7d451-370c-4907-819b-4d9ae1ad5266"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc8b30f1-cc4c-4fc9-8057-a2274c686273"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SprintReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12e41abc-d5ba-49eb-950f-f2ff00dcb2b3"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeanLeftPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d901ad26-aa38-48d8-9007-7d2f931c39ce"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeanRightPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6e43559-ac32-4117-a681-c1a0dbfe8aee"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeanLeftReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a52b347-779f-433c-9711-1ab11298beea"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeanRightReleased"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Weapon"",
            ""id"": ""0f5e5f06-5533-4ee9-a22c-06e755d8f48c"",
            ""actions"": [
                {
                    ""name"": ""Fire2Pressed"",
                    ""type"": ""Button"",
                    ""id"": ""f3b3579e-2ef5-4f14-9de2-fc05c4ce5cc2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire2Released"",
                    ""type"": ""Button"",
                    ""id"": ""6c91579d-d114-4e31-a306-4267d0701d62"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire1Pressed"",
                    ""type"": ""Button"",
                    ""id"": ""1a76504e-8faf-482f-8c18-0426dce0f6a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire1Released"",
                    ""type"": ""Button"",
                    ""id"": ""760908c8-19aa-424b-8f38-511e9e7c6e81"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7600f9a0-9bfd-472f-9ac2-a6cd7ddfeb4f"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire2Pressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38fc40d9-3430-4ec8-bee6-9b7e4e650bd7"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire2Released"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1643523c-0fb5-4e97-b223-4249cd8db719"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire1Pressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3631b89-2b50-4048-9a55-ecd52f757fd5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire1Released"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Character
        m_Character = asset.FindActionMap("Character", throwIfNotFound: true);
        m_Character_Movement = m_Character.FindAction("Movement", throwIfNotFound: true);
        m_Character_View = m_Character.FindAction("View", throwIfNotFound: true);
        m_Character_Jump = m_Character.FindAction("Jump", throwIfNotFound: true);
        m_Character_Crouch = m_Character.FindAction("Crouch", throwIfNotFound: true);
        m_Character_Prone = m_Character.FindAction("Prone", throwIfNotFound: true);
        m_Character_Sprint = m_Character.FindAction("Sprint", throwIfNotFound: true);
        m_Character_SprintReleased = m_Character.FindAction("SprintReleased", throwIfNotFound: true);
        m_Character_LeanLeftPressed = m_Character.FindAction("LeanLeftPressed", throwIfNotFound: true);
        m_Character_LeanRightPressed = m_Character.FindAction("LeanRightPressed", throwIfNotFound: true);
        m_Character_LeanLeftReleased = m_Character.FindAction("LeanLeftReleased", throwIfNotFound: true);
        m_Character_LeanRightReleased = m_Character.FindAction("LeanRightReleased", throwIfNotFound: true);
        // Weapon
        m_Weapon = asset.FindActionMap("Weapon", throwIfNotFound: true);
        m_Weapon_Fire2Pressed = m_Weapon.FindAction("Fire2Pressed", throwIfNotFound: true);
        m_Weapon_Fire2Released = m_Weapon.FindAction("Fire2Released", throwIfNotFound: true);
        m_Weapon_Fire1Pressed = m_Weapon.FindAction("Fire1Pressed", throwIfNotFound: true);
        m_Weapon_Fire1Released = m_Weapon.FindAction("Fire1Released", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Character
    private readonly InputActionMap m_Character;
    private ICharacterActions m_CharacterActionsCallbackInterface;
    private readonly InputAction m_Character_Movement;
    private readonly InputAction m_Character_View;
    private readonly InputAction m_Character_Jump;
    private readonly InputAction m_Character_Crouch;
    private readonly InputAction m_Character_Prone;
    private readonly InputAction m_Character_Sprint;
    private readonly InputAction m_Character_SprintReleased;
    private readonly InputAction m_Character_LeanLeftPressed;
    private readonly InputAction m_Character_LeanRightPressed;
    private readonly InputAction m_Character_LeanLeftReleased;
    private readonly InputAction m_Character_LeanRightReleased;
    public struct CharacterActions
    {
        private @Defaultinput m_Wrapper;
        public CharacterActions(@Defaultinput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Character_Movement;
        public InputAction @View => m_Wrapper.m_Character_View;
        public InputAction @Jump => m_Wrapper.m_Character_Jump;
        public InputAction @Crouch => m_Wrapper.m_Character_Crouch;
        public InputAction @Prone => m_Wrapper.m_Character_Prone;
        public InputAction @Sprint => m_Wrapper.m_Character_Sprint;
        public InputAction @SprintReleased => m_Wrapper.m_Character_SprintReleased;
        public InputAction @LeanLeftPressed => m_Wrapper.m_Character_LeanLeftPressed;
        public InputAction @LeanRightPressed => m_Wrapper.m_Character_LeanRightPressed;
        public InputAction @LeanLeftReleased => m_Wrapper.m_Character_LeanLeftReleased;
        public InputAction @LeanRightReleased => m_Wrapper.m_Character_LeanRightReleased;
        public InputActionMap Get() { return m_Wrapper.m_Character; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterActions instance)
        {
            if (m_Wrapper.m_CharacterActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnMovement;
                @View.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnView;
                @View.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnView;
                @View.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnView;
                @Jump.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @Crouch.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnCrouch;
                @Prone.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnProne;
                @Prone.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnProne;
                @Prone.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnProne;
                @Sprint.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSprint;
                @SprintReleased.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSprintReleased;
                @SprintReleased.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSprintReleased;
                @SprintReleased.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnSprintReleased;
                @LeanLeftPressed.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeanLeftPressed;
                @LeanLeftPressed.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeanLeftPressed;
                @LeanLeftPressed.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeanLeftPressed;
                @LeanRightPressed.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeanRightPressed;
                @LeanRightPressed.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeanRightPressed;
                @LeanRightPressed.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeanRightPressed;
                @LeanLeftReleased.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeanLeftReleased;
                @LeanLeftReleased.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeanLeftReleased;
                @LeanLeftReleased.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeanLeftReleased;
                @LeanRightReleased.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeanRightReleased;
                @LeanRightReleased.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeanRightReleased;
                @LeanRightReleased.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnLeanRightReleased;
            }
            m_Wrapper.m_CharacterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @View.started += instance.OnView;
                @View.performed += instance.OnView;
                @View.canceled += instance.OnView;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Prone.started += instance.OnProne;
                @Prone.performed += instance.OnProne;
                @Prone.canceled += instance.OnProne;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @SprintReleased.started += instance.OnSprintReleased;
                @SprintReleased.performed += instance.OnSprintReleased;
                @SprintReleased.canceled += instance.OnSprintReleased;
                @LeanLeftPressed.started += instance.OnLeanLeftPressed;
                @LeanLeftPressed.performed += instance.OnLeanLeftPressed;
                @LeanLeftPressed.canceled += instance.OnLeanLeftPressed;
                @LeanRightPressed.started += instance.OnLeanRightPressed;
                @LeanRightPressed.performed += instance.OnLeanRightPressed;
                @LeanRightPressed.canceled += instance.OnLeanRightPressed;
                @LeanLeftReleased.started += instance.OnLeanLeftReleased;
                @LeanLeftReleased.performed += instance.OnLeanLeftReleased;
                @LeanLeftReleased.canceled += instance.OnLeanLeftReleased;
                @LeanRightReleased.started += instance.OnLeanRightReleased;
                @LeanRightReleased.performed += instance.OnLeanRightReleased;
                @LeanRightReleased.canceled += instance.OnLeanRightReleased;
            }
        }
    }
    public CharacterActions @Character => new CharacterActions(this);

    // Weapon
    private readonly InputActionMap m_Weapon;
    private IWeaponActions m_WeaponActionsCallbackInterface;
    private readonly InputAction m_Weapon_Fire2Pressed;
    private readonly InputAction m_Weapon_Fire2Released;
    private readonly InputAction m_Weapon_Fire1Pressed;
    private readonly InputAction m_Weapon_Fire1Released;
    public struct WeaponActions
    {
        private @Defaultinput m_Wrapper;
        public WeaponActions(@Defaultinput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fire2Pressed => m_Wrapper.m_Weapon_Fire2Pressed;
        public InputAction @Fire2Released => m_Wrapper.m_Weapon_Fire2Released;
        public InputAction @Fire1Pressed => m_Wrapper.m_Weapon_Fire1Pressed;
        public InputAction @Fire1Released => m_Wrapper.m_Weapon_Fire1Released;
        public InputActionMap Get() { return m_Wrapper.m_Weapon; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WeaponActions set) { return set.Get(); }
        public void SetCallbacks(IWeaponActions instance)
        {
            if (m_Wrapper.m_WeaponActionsCallbackInterface != null)
            {
                @Fire2Pressed.started -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire2Pressed;
                @Fire2Pressed.performed -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire2Pressed;
                @Fire2Pressed.canceled -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire2Pressed;
                @Fire2Released.started -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire2Released;
                @Fire2Released.performed -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire2Released;
                @Fire2Released.canceled -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire2Released;
                @Fire1Pressed.started -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire1Pressed;
                @Fire1Pressed.performed -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire1Pressed;
                @Fire1Pressed.canceled -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire1Pressed;
                @Fire1Released.started -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire1Released;
                @Fire1Released.performed -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire1Released;
                @Fire1Released.canceled -= m_Wrapper.m_WeaponActionsCallbackInterface.OnFire1Released;
            }
            m_Wrapper.m_WeaponActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fire2Pressed.started += instance.OnFire2Pressed;
                @Fire2Pressed.performed += instance.OnFire2Pressed;
                @Fire2Pressed.canceled += instance.OnFire2Pressed;
                @Fire2Released.started += instance.OnFire2Released;
                @Fire2Released.performed += instance.OnFire2Released;
                @Fire2Released.canceled += instance.OnFire2Released;
                @Fire1Pressed.started += instance.OnFire1Pressed;
                @Fire1Pressed.performed += instance.OnFire1Pressed;
                @Fire1Pressed.canceled += instance.OnFire1Pressed;
                @Fire1Released.started += instance.OnFire1Released;
                @Fire1Released.performed += instance.OnFire1Released;
                @Fire1Released.canceled += instance.OnFire1Released;
            }
        }
    }
    public WeaponActions @Weapon => new WeaponActions(this);
    public interface ICharacterActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnView(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnProne(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnSprintReleased(InputAction.CallbackContext context);
        void OnLeanLeftPressed(InputAction.CallbackContext context);
        void OnLeanRightPressed(InputAction.CallbackContext context);
        void OnLeanLeftReleased(InputAction.CallbackContext context);
        void OnLeanRightReleased(InputAction.CallbackContext context);
    }
    public interface IWeaponActions
    {
        void OnFire2Pressed(InputAction.CallbackContext context);
        void OnFire2Released(InputAction.CallbackContext context);
        void OnFire1Pressed(InputAction.CallbackContext context);
        void OnFire1Released(InputAction.CallbackContext context);
    }
}
