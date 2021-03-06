//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Player Interaction/PlayerControls.inputactions
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

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerActions"",
            ""id"": ""3bd78026-7ee5-44b9-8364-8ba10c2c9cd0"",
            ""actions"": [
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""8e68d9db-bf71-4bd9-a567-82def4b74919"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AltSelect"",
                    ""type"": ""Button"",
                    ""id"": ""b7ecc481-29ae-479d-bbd3-58d769ea3fc0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CameraMovement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""18a7d5bc-b0bb-443a-a984-081f0f06e238"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d1a6bc7e-8343-4cc2-abb3-8a15cca148b5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ToggleRun"",
                    ""type"": ""Button"",
                    ""id"": ""054f0368-4ccb-42ed-8c6c-01b977e038d2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ToggleInventory"",
                    ""type"": ""Button"",
                    ""id"": ""0cc217e7-a6a7-4090-884f-40e0f3413160"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8a7ed299-fee6-4fcb-8973-d22c25ed8ad9"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e095a3d3-c6d9-4f3a-9950-338562e21353"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AltSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""b399166c-cea0-4952-8e02-def03fefc5f9"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2b3e3ded-7d78-40d3-9a97-a8fb7a44357f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""343dd4cb-4a35-48b9-9288-ead88605ba4d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f0746d55-c78c-416c-8b73-13390fd881a1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""15e7d1dc-0b19-4261-aea3-f4a1d577ed04"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""4f0bd3dd-42ac-4c7a-8c9d-f9456e229c86"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d2b31ef1-e4ab-4202-827b-196cb23f1587"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f53dfd86-3404-49fa-bd32-1806211a2187"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7923cc43-afdd-45a0-a9fe-8a43451042a7"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""46bd4520-4c23-4b36-a85d-dbc06f0e4436"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8bcad52b-1e92-4944-bd6f-4cca4996b05c"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17f1699c-f4ac-4b40-9e42-759e6ff79839"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleRun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5421042f-6072-4c84-bffe-266aaaac9b98"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleInventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerActions
        m_PlayerActions = asset.FindActionMap("PlayerActions", throwIfNotFound: true);
        m_PlayerActions_Select = m_PlayerActions.FindAction("Select", throwIfNotFound: true);
        m_PlayerActions_AltSelect = m_PlayerActions.FindAction("AltSelect", throwIfNotFound: true);
        m_PlayerActions_CameraMovement = m_PlayerActions.FindAction("CameraMovement", throwIfNotFound: true);
        m_PlayerActions_MousePosition = m_PlayerActions.FindAction("MousePosition", throwIfNotFound: true);
        m_PlayerActions_ToggleRun = m_PlayerActions.FindAction("ToggleRun", throwIfNotFound: true);
        m_PlayerActions_ToggleInventory = m_PlayerActions.FindAction("ToggleInventory", throwIfNotFound: true);
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

    // PlayerActions
    private readonly InputActionMap m_PlayerActions;
    private IPlayerActionsActions m_PlayerActionsActionsCallbackInterface;
    private readonly InputAction m_PlayerActions_Select;
    private readonly InputAction m_PlayerActions_AltSelect;
    private readonly InputAction m_PlayerActions_CameraMovement;
    private readonly InputAction m_PlayerActions_MousePosition;
    private readonly InputAction m_PlayerActions_ToggleRun;
    private readonly InputAction m_PlayerActions_ToggleInventory;
    public struct PlayerActionsActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActionsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Select => m_Wrapper.m_PlayerActions_Select;
        public InputAction @AltSelect => m_Wrapper.m_PlayerActions_AltSelect;
        public InputAction @CameraMovement => m_Wrapper.m_PlayerActions_CameraMovement;
        public InputAction @MousePosition => m_Wrapper.m_PlayerActions_MousePosition;
        public InputAction @ToggleRun => m_Wrapper.m_PlayerActions_ToggleRun;
        public InputAction @ToggleInventory => m_Wrapper.m_PlayerActions_ToggleInventory;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionsActions instance)
        {
            if (m_Wrapper.m_PlayerActionsActionsCallbackInterface != null)
            {
                @Select.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnSelect;
                @AltSelect.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnAltSelect;
                @AltSelect.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnAltSelect;
                @AltSelect.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnAltSelect;
                @CameraMovement.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnCameraMovement;
                @CameraMovement.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnCameraMovement;
                @CameraMovement.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnCameraMovement;
                @MousePosition.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMousePosition;
                @ToggleRun.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnToggleRun;
                @ToggleRun.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnToggleRun;
                @ToggleRun.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnToggleRun;
                @ToggleInventory.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnToggleInventory;
                @ToggleInventory.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnToggleInventory;
                @ToggleInventory.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnToggleInventory;
            }
            m_Wrapper.m_PlayerActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @AltSelect.started += instance.OnAltSelect;
                @AltSelect.performed += instance.OnAltSelect;
                @AltSelect.canceled += instance.OnAltSelect;
                @CameraMovement.started += instance.OnCameraMovement;
                @CameraMovement.performed += instance.OnCameraMovement;
                @CameraMovement.canceled += instance.OnCameraMovement;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @ToggleRun.started += instance.OnToggleRun;
                @ToggleRun.performed += instance.OnToggleRun;
                @ToggleRun.canceled += instance.OnToggleRun;
                @ToggleInventory.started += instance.OnToggleInventory;
                @ToggleInventory.performed += instance.OnToggleInventory;
                @ToggleInventory.canceled += instance.OnToggleInventory;
            }
        }
    }
    public PlayerActionsActions @PlayerActions => new PlayerActionsActions(this);
    public interface IPlayerActionsActions
    {
        void OnSelect(InputAction.CallbackContext context);
        void OnAltSelect(InputAction.CallbackContext context);
        void OnCameraMovement(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnToggleRun(InputAction.CallbackContext context);
        void OnToggleInventory(InputAction.CallbackContext context);
    }
}
