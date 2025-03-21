//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/_Assets/Configs/Game.inputactions
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

public partial class @Game: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Game()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Game"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""cb16b051-11bd-476d-8939-931150f65bce"",
            ""actions"": [
                {
                    ""name"": ""SetDestination"",
                    ""type"": ""Value"",
                    ""id"": ""7ddacec1-a6e6-42cf-a3f8-fa378001c5a8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveToDestination"",
                    ""type"": ""Button"",
                    ""id"": ""beb0ae6c-a5d5-4117-99bd-ef25dd8d6b31"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1dd6a899-d003-47d8-a7b1-c416001267da"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""SetDestination"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e49d9848-40cb-4e2e-95fb-f1db5e77e0d5"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""SetDestination"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f286560b-5736-46ad-83ef-6dafa23a05b3"",
                    ""path"": ""<Touchscreen>/{PrimaryAction}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveToDestination"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5843b225-c4ce-4b74-9a1a-f516bb4d009a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveToDestination"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Player"",
            ""bindingGroup"": ""Player"",
            ""devices"": []
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_SetDestination = m_Player.FindAction("SetDestination", throwIfNotFound: true);
        m_Player_MoveToDestination = m_Player.FindAction("MoveToDestination", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_SetDestination;
    private readonly InputAction m_Player_MoveToDestination;
    public struct PlayerActions
    {
        private @Game m_Wrapper;
        public PlayerActions(@Game wrapper) { m_Wrapper = wrapper; }
        public InputAction @SetDestination => m_Wrapper.m_Player_SetDestination;
        public InputAction @MoveToDestination => m_Wrapper.m_Player_MoveToDestination;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @SetDestination.started += instance.OnSetDestination;
            @SetDestination.performed += instance.OnSetDestination;
            @SetDestination.canceled += instance.OnSetDestination;
            @MoveToDestination.started += instance.OnMoveToDestination;
            @MoveToDestination.performed += instance.OnMoveToDestination;
            @MoveToDestination.canceled += instance.OnMoveToDestination;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @SetDestination.started -= instance.OnSetDestination;
            @SetDestination.performed -= instance.OnSetDestination;
            @SetDestination.canceled -= instance.OnSetDestination;
            @MoveToDestination.started -= instance.OnMoveToDestination;
            @MoveToDestination.performed -= instance.OnMoveToDestination;
            @MoveToDestination.canceled -= instance.OnMoveToDestination;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_PlayerSchemeIndex = -1;
    public InputControlScheme PlayerScheme
    {
        get
        {
            if (m_PlayerSchemeIndex == -1) m_PlayerSchemeIndex = asset.FindControlSchemeIndex("Player");
            return asset.controlSchemes[m_PlayerSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnSetDestination(InputAction.CallbackContext context);
        void OnMoveToDestination(InputAction.CallbackContext context);
    }
}
