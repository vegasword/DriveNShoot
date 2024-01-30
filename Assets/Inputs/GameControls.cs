//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Inputs/GameControls.inputactions
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

public partial class @GameControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameControls"",
    ""maps"": [
        {
            ""name"": ""OnFoot"",
            ""id"": ""f8129ed4-f899-41f8-90d0-0416fe2eb8aa"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""5e251837-f7ac-4b2c-9839-414037e3f956"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""2b1c2925-77ea-4822-91cb-bf31594051f3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""AimMouse"",
                    ""type"": ""Button"",
                    ""id"": ""c8b8748f-fa57-47d4-ad71-fc54a2031c77"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2faf8d30-bb38-48ef-8753-703e6d7c8cab"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""9b51b52c-0bac-49ec-9ce3-6406ca7ab4aa"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b34e8653-131f-4b7d-b296-d8a66ebbc931"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ab31d129-1f1b-472b-b559-db9c7ccb67d3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cce30469-b3a9-4f51-a4cb-4e4254854422"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b4a26284-2bc3-4350-990c-f9c559026f25"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ec6bac10-e060-4bd9-ba9d-52347f821f55"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e66e4466-99ac-4b0b-abf7-c02785e3edfb"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""AimMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""InVehicle"",
            ""id"": ""b17082da-367a-4fe9-9ab1-1e35827bea2a"",
            ""actions"": [
                {
                    ""name"": ""Turn"",
                    ""type"": ""Value"",
                    ""id"": ""70129a8c-be31-4795-aa1c-0288ed403cd7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""56e4562a-4895-4db6-8197-bbb4905fdc0b"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""QD"",
                    ""id"": ""0d72ceb6-ecdf-49d0-bd54-26f4880b9c85"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ea69f2e6-3e9c-49c3-9c5c-b71af9b49827"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5086f08a-cb61-404a-93e6-d18f5d5b9386"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""KBM"",
            ""bindingGroup"": ""KBM"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // OnFoot
        m_OnFoot = asset.FindActionMap("OnFoot", throwIfNotFound: true);
        m_OnFoot_Move = m_OnFoot.FindAction("Move", throwIfNotFound: true);
        m_OnFoot_Aim = m_OnFoot.FindAction("Aim", throwIfNotFound: true);
        m_OnFoot_AimMouse = m_OnFoot.FindAction("AimMouse", throwIfNotFound: true);
        // InVehicle
        m_InVehicle = asset.FindActionMap("InVehicle", throwIfNotFound: true);
        m_InVehicle_Turn = m_InVehicle.FindAction("Turn", throwIfNotFound: true);
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

    // OnFoot
    private readonly InputActionMap m_OnFoot;
    private List<IOnFootActions> m_OnFootActionsCallbackInterfaces = new List<IOnFootActions>();
    private readonly InputAction m_OnFoot_Move;
    private readonly InputAction m_OnFoot_Aim;
    private readonly InputAction m_OnFoot_AimMouse;
    public struct OnFootActions
    {
        private @GameControls m_Wrapper;
        public OnFootActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_OnFoot_Move;
        public InputAction @Aim => m_Wrapper.m_OnFoot_Aim;
        public InputAction @AimMouse => m_Wrapper.m_OnFoot_AimMouse;
        public InputActionMap Get() { return m_Wrapper.m_OnFoot; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OnFootActions set) { return set.Get(); }
        public void AddCallbacks(IOnFootActions instance)
        {
            if (instance == null || m_Wrapper.m_OnFootActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_OnFootActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Aim.started += instance.OnAim;
            @Aim.performed += instance.OnAim;
            @Aim.canceled += instance.OnAim;
            @AimMouse.started += instance.OnAimMouse;
            @AimMouse.performed += instance.OnAimMouse;
            @AimMouse.canceled += instance.OnAimMouse;
        }

        private void UnregisterCallbacks(IOnFootActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Aim.started -= instance.OnAim;
            @Aim.performed -= instance.OnAim;
            @Aim.canceled -= instance.OnAim;
            @AimMouse.started -= instance.OnAimMouse;
            @AimMouse.performed -= instance.OnAimMouse;
            @AimMouse.canceled -= instance.OnAimMouse;
        }

        public void RemoveCallbacks(IOnFootActions instance)
        {
            if (m_Wrapper.m_OnFootActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IOnFootActions instance)
        {
            foreach (var item in m_Wrapper.m_OnFootActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_OnFootActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public OnFootActions @OnFoot => new OnFootActions(this);

    // InVehicle
    private readonly InputActionMap m_InVehicle;
    private List<IInVehicleActions> m_InVehicleActionsCallbackInterfaces = new List<IInVehicleActions>();
    private readonly InputAction m_InVehicle_Turn;
    public struct InVehicleActions
    {
        private @GameControls m_Wrapper;
        public InVehicleActions(@GameControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Turn => m_Wrapper.m_InVehicle_Turn;
        public InputActionMap Get() { return m_Wrapper.m_InVehicle; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InVehicleActions set) { return set.Get(); }
        public void AddCallbacks(IInVehicleActions instance)
        {
            if (instance == null || m_Wrapper.m_InVehicleActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_InVehicleActionsCallbackInterfaces.Add(instance);
            @Turn.started += instance.OnTurn;
            @Turn.performed += instance.OnTurn;
            @Turn.canceled += instance.OnTurn;
        }

        private void UnregisterCallbacks(IInVehicleActions instance)
        {
            @Turn.started -= instance.OnTurn;
            @Turn.performed -= instance.OnTurn;
            @Turn.canceled -= instance.OnTurn;
        }

        public void RemoveCallbacks(IInVehicleActions instance)
        {
            if (m_Wrapper.m_InVehicleActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IInVehicleActions instance)
        {
            foreach (var item in m_Wrapper.m_InVehicleActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_InVehicleActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public InVehicleActions @InVehicle => new InVehicleActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_KBMSchemeIndex = -1;
    public InputControlScheme KBMScheme
    {
        get
        {
            if (m_KBMSchemeIndex == -1) m_KBMSchemeIndex = asset.FindControlSchemeIndex("KBM");
            return asset.controlSchemes[m_KBMSchemeIndex];
        }
    }
    public interface IOnFootActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnAimMouse(InputAction.CallbackContext context);
    }
    public interface IInVehicleActions
    {
        void OnTurn(InputAction.CallbackContext context);
    }
}
