// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Combat"",
            ""id"": ""46bf5dd5-4f32-4126-be38-9b11ff707bf6"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""696e5e6f-ff7c-4c11-a9c5-ad9e628e02fa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Air Extender"",
                    ""type"": ""Button"",
                    ""id"": ""340ec381-5b08-4986-a982-49123cf75250"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Air Starter"",
                    ""type"": ""Button"",
                    ""id"": ""07d18c71-7b44-4a4e-9c15-d522e9aa3a18"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Air Finisher"",
                    ""type"": ""Button"",
                    ""id"": ""cd9c36b8-7adc-4b75-aa42-ded5db822a7f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ground Extender"",
                    ""type"": ""Button"",
                    ""id"": ""f3c769a5-3249-47f3-b845-18afbd67b7f5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ground Starter"",
                    ""type"": ""Button"",
                    ""id"": ""8a2e74c0-4fa6-4baf-95b5-a8d05bf8a579"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ground Finisher"",
                    ""type"": ""Button"",
                    ""id"": ""297a72c5-08f0-48a7-b7f1-c751cdc225c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""039d282c-c5ef-4ea7-8bcb-c1d4047a7b57"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c9dce4e1-2e88-4cc3-94ef-c48a55d284b8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b03d0e5-05ac-46d9-ae44-bbe6f4f2a2e9"",
                    ""path"": ""<Keyboard>/numpad5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98c29c5a-27b5-439b-9cd2-5092039f908c"",
                    ""path"": ""<Keyboard>/numpad8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Air Extender"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62af7156-dcc1-404d-95f2-44d7c304a166"",
                    ""path"": ""<Keyboard>/numpad7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Air Starter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cfe87ad2-8f5d-416b-b37b-5a861efec48d"",
                    ""path"": ""<Keyboard>/numpad9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Air Finisher"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1c629e12-9c0d-460c-b949-d368004505d4"",
                    ""path"": ""<Keyboard>/numpad2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Ground Extender"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6cea07ed-810e-458c-ae7b-50354f1986d2"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Ground Starter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""886d4050-1021-4372-922f-2f079dfd5b14"",
                    ""path"": ""<Keyboard>/numpad3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Ground Finisher"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""a330cd96-4a43-43ce-b847-d6c4d2c362a4"",
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
                    ""id"": ""1dd43254-481f-46f2-ac13-fd76c9af5e69"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b7f6da11-c226-4608-ba69-ea38b3b4c844"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""55ef24b7-92e5-4cc4-bda6-de05990a5d0e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5ee67707-9241-431a-837b-e8790213ffa2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""91977212-ed55-4341-964f-e1626ebe1adb"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""a05f33aa-337f-4cc8-84f9-54096b71cfe4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2b5d95f8-a804-419c-bb0a-c722d2e302f8"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Combat
        m_Combat = asset.FindActionMap("Combat", throwIfNotFound: true);
        m_Combat_Jump = m_Combat.FindAction("Jump", throwIfNotFound: true);
        m_Combat_AirExtender = m_Combat.FindAction("Air Extender", throwIfNotFound: true);
        m_Combat_AirStarter = m_Combat.FindAction("Air Starter", throwIfNotFound: true);
        m_Combat_AirFinisher = m_Combat.FindAction("Air Finisher", throwIfNotFound: true);
        m_Combat_GroundExtender = m_Combat.FindAction("Ground Extender", throwIfNotFound: true);
        m_Combat_GroundStarter = m_Combat.FindAction("Ground Starter", throwIfNotFound: true);
        m_Combat_GroundFinisher = m_Combat.FindAction("Ground Finisher", throwIfNotFound: true);
        m_Combat_Move = m_Combat.FindAction("Move", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Newaction = m_Menu.FindAction("New action", throwIfNotFound: true);
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

    // Combat
    private readonly InputActionMap m_Combat;
    private ICombatActions m_CombatActionsCallbackInterface;
    private readonly InputAction m_Combat_Jump;
    private readonly InputAction m_Combat_AirExtender;
    private readonly InputAction m_Combat_AirStarter;
    private readonly InputAction m_Combat_AirFinisher;
    private readonly InputAction m_Combat_GroundExtender;
    private readonly InputAction m_Combat_GroundStarter;
    private readonly InputAction m_Combat_GroundFinisher;
    private readonly InputAction m_Combat_Move;
    public struct CombatActions
    {
        private @PlayerControls m_Wrapper;
        public CombatActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Combat_Jump;
        public InputAction @AirExtender => m_Wrapper.m_Combat_AirExtender;
        public InputAction @AirStarter => m_Wrapper.m_Combat_AirStarter;
        public InputAction @AirFinisher => m_Wrapper.m_Combat_AirFinisher;
        public InputAction @GroundExtender => m_Wrapper.m_Combat_GroundExtender;
        public InputAction @GroundStarter => m_Wrapper.m_Combat_GroundStarter;
        public InputAction @GroundFinisher => m_Wrapper.m_Combat_GroundFinisher;
        public InputAction @Move => m_Wrapper.m_Combat_Move;
        public InputActionMap Get() { return m_Wrapper.m_Combat; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CombatActions set) { return set.Get(); }
        public void SetCallbacks(ICombatActions instance)
        {
            if (m_Wrapper.m_CombatActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnJump;
                @AirExtender.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnAirExtender;
                @AirExtender.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnAirExtender;
                @AirExtender.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnAirExtender;
                @AirStarter.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnAirStarter;
                @AirStarter.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnAirStarter;
                @AirStarter.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnAirStarter;
                @AirFinisher.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnAirFinisher;
                @AirFinisher.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnAirFinisher;
                @AirFinisher.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnAirFinisher;
                @GroundExtender.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnGroundExtender;
                @GroundExtender.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnGroundExtender;
                @GroundExtender.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnGroundExtender;
                @GroundStarter.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnGroundStarter;
                @GroundStarter.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnGroundStarter;
                @GroundStarter.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnGroundStarter;
                @GroundFinisher.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnGroundFinisher;
                @GroundFinisher.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnGroundFinisher;
                @GroundFinisher.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnGroundFinisher;
                @Move.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_CombatActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @AirExtender.started += instance.OnAirExtender;
                @AirExtender.performed += instance.OnAirExtender;
                @AirExtender.canceled += instance.OnAirExtender;
                @AirStarter.started += instance.OnAirStarter;
                @AirStarter.performed += instance.OnAirStarter;
                @AirStarter.canceled += instance.OnAirStarter;
                @AirFinisher.started += instance.OnAirFinisher;
                @AirFinisher.performed += instance.OnAirFinisher;
                @AirFinisher.canceled += instance.OnAirFinisher;
                @GroundExtender.started += instance.OnGroundExtender;
                @GroundExtender.performed += instance.OnGroundExtender;
                @GroundExtender.canceled += instance.OnGroundExtender;
                @GroundStarter.started += instance.OnGroundStarter;
                @GroundStarter.performed += instance.OnGroundStarter;
                @GroundStarter.canceled += instance.OnGroundStarter;
                @GroundFinisher.started += instance.OnGroundFinisher;
                @GroundFinisher.performed += instance.OnGroundFinisher;
                @GroundFinisher.canceled += instance.OnGroundFinisher;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public CombatActions @Combat => new CombatActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Newaction;
    public struct MenuActions
    {
        private @PlayerControls m_Wrapper;
        public MenuActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Menu_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    public interface ICombatActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnAirExtender(InputAction.CallbackContext context);
        void OnAirStarter(InputAction.CallbackContext context);
        void OnAirFinisher(InputAction.CallbackContext context);
        void OnGroundExtender(InputAction.CallbackContext context);
        void OnGroundStarter(InputAction.CallbackContext context);
        void OnGroundFinisher(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
