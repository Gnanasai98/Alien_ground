//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/_Scripts/Controller/MasterInputs.inputactions
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

public partial class @MasterInputs : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @MasterInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MasterInputs"",
    ""maps"": [
        {
            ""name"": ""PlayerActions"",
            ""id"": ""215aeeff-4e4a-4a82-aca5-b9b8619dfbe7"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""7e16fa97-7060-4a22-803d-c242cefb929b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""e72711d3-580b-4359-91ce-84583f6eb7e2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a6962656-618c-41bb-baa2-f8a6cf7dbfda"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ccd7a506-0f4d-4da4-9b45-008a683e1f61"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""75b1d36c-b1dd-4d80-8133-fcfebe551abf"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Left"",
                    ""id"": ""ed65587e-6cdb-4e8c-9880-12b57458eb4f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""7db1235e-b6e0-4ab4-be77-974d98db3b29"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerActions
        m_PlayerActions = asset.FindActionMap("PlayerActions", throwIfNotFound: true);
        m_PlayerActions_Up = m_PlayerActions.FindAction("Up", throwIfNotFound: true);
        m_PlayerActions_Move = m_PlayerActions.FindAction("Move", throwIfNotFound: true);
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
    private readonly InputAction m_PlayerActions_Up;
    private readonly InputAction m_PlayerActions_Move;
    public struct PlayerActionsActions
    {
        private @MasterInputs m_Wrapper;
        public PlayerActionsActions(@MasterInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_PlayerActions_Up;
        public InputAction @Move => m_Wrapper.m_PlayerActions_Move;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionsActions instance)
        {
            if (m_Wrapper.m_PlayerActionsActionsCallbackInterface != null)
            {
                @Up.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnUp;
                @Move.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_PlayerActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public PlayerActionsActions @PlayerActions => new PlayerActionsActions(this);
    public interface IPlayerActionsActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}
