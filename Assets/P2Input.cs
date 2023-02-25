//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/P2Input.inputactions
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

public partial class @P2Input : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @P2Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""P2Input"",
    ""maps"": [
        {
            ""name"": ""Normal"",
            ""id"": ""ca1c377c-e248-41b4-9a4b-3413a4b3cc1e"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""c119b4e2-6779-4c5f-b472-56e567de7bee"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""30df7dce-d8e6-449c-a5dc-46f0a509250f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""7233f2da-b1ad-4cc8-9dd6-f04bb052b78a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""57522640-7319-43ea-943f-f91d3a4a0cab"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""80113a5f-1b82-4943-9f1d-ab58fe075e7b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""45da639b-7063-4907-b001-df7f5e0e8716"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""de8aec79-1ff6-481c-a577-8d6dd8205916"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1be6b104-3f34-4b04-99f1-fcfacda004af"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Drive"",
            ""id"": ""66cab1a8-e253-469c-a40c-c91a97d23694"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""744c5e3f-e374-4467-b51c-45d0e04bfa77"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""b9f5c44e-374b-4edc-9408-60fc653436ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""954e67e1-5bc3-4e28-975a-a693279f06bf"",
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
                    ""id"": ""7f748de2-79c3-44ee-8adf-cf0865a343cb"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f02aded4-f57d-48a5-9e45-ef64db19f378"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ab97dcae-2360-497d-92a1-3008fe9b0aef"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e652ab77-d616-4cb5-b4b9-fcfdb08f30bb"",
                    ""path"": ""<Keyboard>/slash"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Shoot"",
            ""id"": ""1fba6927-ca42-4c1d-9f18-4d3a8b229a03"",
            ""actions"": [
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""b1e83138-e07d-4c3d-86ba-51c432a28e22"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""70130544-9bae-45bb-b113-2caa519c6126"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""f9179b75-d16d-4028-9c70-12133d455dc0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""8a188033-1dcf-45e7-bb29-a2258050ebc9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""364aba6f-0f1f-4572-8a5b-0e14ff3fb769"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""501b9f48-cbe6-4745-8ba4-b0e0898d0e8e"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""96c9818b-fc91-4ebf-9fc5-4279b60a0f33"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b48a2738-9cbe-411f-a9fa-94b9b833c360"",
                    ""path"": ""<Keyboard>/slash"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Operating"",
            ""id"": ""b71bed1d-bfd8-4789-98db-50e24f13deaf"",
            ""actions"": [
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""1fc6262b-64a0-43e0-bca9-d1bcacad35a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""929201f1-1f6d-4bbf-855d-2e1f66a384aa"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""2e759277-7f1e-4d4b-a255-8c5dbe335666"",
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
                    ""id"": ""a45d872f-9d29-4245-a353-a0df2adf55e9"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""da214b2d-f074-47de-82d3-923b187d29b1"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e56a6ff0-79f3-4d92-9cff-bc4f19128058"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ff4eaaef-4255-456d-bf16-94ae563d0039"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6ecdf024-ac7b-4d00-9e3d-a77b92001aae"",
                    ""path"": ""<Keyboard>/slash"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Normal
        m_Normal = asset.FindActionMap("Normal", throwIfNotFound: true);
        m_Normal_Movement = m_Normal.FindAction("Movement", throwIfNotFound: true);
        m_Normal_Jump = m_Normal.FindAction("Jump", throwIfNotFound: true);
        m_Normal_Interact = m_Normal.FindAction("Interact", throwIfNotFound: true);
        // Drive
        m_Drive = asset.FindActionMap("Drive", throwIfNotFound: true);
        m_Drive_Movement = m_Drive.FindAction("Movement", throwIfNotFound: true);
        m_Drive_Exit = m_Drive.FindAction("Exit", throwIfNotFound: true);
        // Shoot
        m_Shoot = asset.FindActionMap("Shoot", throwIfNotFound: true);
        m_Shoot_Aim = m_Shoot.FindAction("Aim", throwIfNotFound: true);
        m_Shoot_Fire = m_Shoot.FindAction("Fire", throwIfNotFound: true);
        m_Shoot_Exit = m_Shoot.FindAction("Exit", throwIfNotFound: true);
        // Operating
        m_Operating = asset.FindActionMap("Operating", throwIfNotFound: true);
        m_Operating_Exit = m_Operating.FindAction("Exit", throwIfNotFound: true);
        m_Operating_Movement = m_Operating.FindAction("Movement", throwIfNotFound: true);
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

    // Normal
    private readonly InputActionMap m_Normal;
    private INormalActions m_NormalActionsCallbackInterface;
    private readonly InputAction m_Normal_Movement;
    private readonly InputAction m_Normal_Jump;
    private readonly InputAction m_Normal_Interact;
    public struct NormalActions
    {
        private @P2Input m_Wrapper;
        public NormalActions(@P2Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Normal_Movement;
        public InputAction @Jump => m_Wrapper.m_Normal_Jump;
        public InputAction @Interact => m_Wrapper.m_Normal_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Normal; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NormalActions set) { return set.Get(); }
        public void SetCallbacks(INormalActions instance)
        {
            if (m_Wrapper.m_NormalActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnJump;
                @Interact.started -= m_Wrapper.m_NormalActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_NormalActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_NormalActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_NormalActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public NormalActions @Normal => new NormalActions(this);

    // Drive
    private readonly InputActionMap m_Drive;
    private IDriveActions m_DriveActionsCallbackInterface;
    private readonly InputAction m_Drive_Movement;
    private readonly InputAction m_Drive_Exit;
    public struct DriveActions
    {
        private @P2Input m_Wrapper;
        public DriveActions(@P2Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Drive_Movement;
        public InputAction @Exit => m_Wrapper.m_Drive_Exit;
        public InputActionMap Get() { return m_Wrapper.m_Drive; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DriveActions set) { return set.Get(); }
        public void SetCallbacks(IDriveActions instance)
        {
            if (m_Wrapper.m_DriveActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_DriveActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_DriveActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_DriveActionsCallbackInterface.OnMovement;
                @Exit.started -= m_Wrapper.m_DriveActionsCallbackInterface.OnExit;
                @Exit.performed -= m_Wrapper.m_DriveActionsCallbackInterface.OnExit;
                @Exit.canceled -= m_Wrapper.m_DriveActionsCallbackInterface.OnExit;
            }
            m_Wrapper.m_DriveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Exit.started += instance.OnExit;
                @Exit.performed += instance.OnExit;
                @Exit.canceled += instance.OnExit;
            }
        }
    }
    public DriveActions @Drive => new DriveActions(this);

    // Shoot
    private readonly InputActionMap m_Shoot;
    private IShootActions m_ShootActionsCallbackInterface;
    private readonly InputAction m_Shoot_Aim;
    private readonly InputAction m_Shoot_Fire;
    private readonly InputAction m_Shoot_Exit;
    public struct ShootActions
    {
        private @P2Input m_Wrapper;
        public ShootActions(@P2Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Aim => m_Wrapper.m_Shoot_Aim;
        public InputAction @Fire => m_Wrapper.m_Shoot_Fire;
        public InputAction @Exit => m_Wrapper.m_Shoot_Exit;
        public InputActionMap Get() { return m_Wrapper.m_Shoot; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShootActions set) { return set.Get(); }
        public void SetCallbacks(IShootActions instance)
        {
            if (m_Wrapper.m_ShootActionsCallbackInterface != null)
            {
                @Aim.started -= m_Wrapper.m_ShootActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_ShootActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_ShootActionsCallbackInterface.OnAim;
                @Fire.started -= m_Wrapper.m_ShootActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_ShootActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_ShootActionsCallbackInterface.OnFire;
                @Exit.started -= m_Wrapper.m_ShootActionsCallbackInterface.OnExit;
                @Exit.performed -= m_Wrapper.m_ShootActionsCallbackInterface.OnExit;
                @Exit.canceled -= m_Wrapper.m_ShootActionsCallbackInterface.OnExit;
            }
            m_Wrapper.m_ShootActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Exit.started += instance.OnExit;
                @Exit.performed += instance.OnExit;
                @Exit.canceled += instance.OnExit;
            }
        }
    }
    public ShootActions @Shoot => new ShootActions(this);

    // Operating
    private readonly InputActionMap m_Operating;
    private IOperatingActions m_OperatingActionsCallbackInterface;
    private readonly InputAction m_Operating_Exit;
    private readonly InputAction m_Operating_Movement;
    public struct OperatingActions
    {
        private @P2Input m_Wrapper;
        public OperatingActions(@P2Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Exit => m_Wrapper.m_Operating_Exit;
        public InputAction @Movement => m_Wrapper.m_Operating_Movement;
        public InputActionMap Get() { return m_Wrapper.m_Operating; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OperatingActions set) { return set.Get(); }
        public void SetCallbacks(IOperatingActions instance)
        {
            if (m_Wrapper.m_OperatingActionsCallbackInterface != null)
            {
                @Exit.started -= m_Wrapper.m_OperatingActionsCallbackInterface.OnExit;
                @Exit.performed -= m_Wrapper.m_OperatingActionsCallbackInterface.OnExit;
                @Exit.canceled -= m_Wrapper.m_OperatingActionsCallbackInterface.OnExit;
                @Movement.started -= m_Wrapper.m_OperatingActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_OperatingActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_OperatingActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_OperatingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Exit.started += instance.OnExit;
                @Exit.performed += instance.OnExit;
                @Exit.canceled += instance.OnExit;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public OperatingActions @Operating => new OperatingActions(this);
    public interface INormalActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IDriveActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnExit(InputAction.CallbackContext context);
    }
    public interface IShootActions
    {
        void OnAim(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnExit(InputAction.CallbackContext context);
    }
    public interface IOperatingActions
    {
        void OnExit(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
    }
}
