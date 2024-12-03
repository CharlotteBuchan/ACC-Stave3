//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Custom Examples/LEGO Character/Characters/Input Actions/Player Input Actions.inputactions
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

public partial class @PlayerInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Input Actions"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""8a7c8e23-10b5-4284-b7cf-99ca208627c6"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""29ee54b0-2556-4d03-bc01-6ed1d1cb1163"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""c64e4011-7b94-4e4d-b307-8254a42521c6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""b125b605-04e9-408e-8b19-ee805b633c6b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dive"",
                    ""type"": ""Button"",
                    ""id"": ""7ee481cf-966c-44ff-b22b-a7e99c07b06d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Swim Up"",
                    ""type"": ""Button"",
                    ""id"": ""cba6350d-f676-4216-b9eb-3bd680a06d18"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""6799ceec-4663-42e6-b9a2-3f011c93709a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PickAndDrop"",
                    ""type"": ""Button"",
                    ""id"": ""dc692eeb-3f49-43ea-bca1-f1bcc1b6f54e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""91fa11d6-df5d-4d02-83e3-e3fbaaebbda9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Spin"",
                    ""type"": ""Button"",
                    ""id"": ""346795bb-dca6-4700-96d4-6a1feebbe42e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Stomp"",
                    ""type"": ""Button"",
                    ""id"": ""010b42d7-32ab-4e0c-87a7-ad984d342ee8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""AirDive"",
                    ""type"": ""Button"",
                    ""id"": ""302ddadf-5097-4605-9c7a-f0b6721ca879"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ReleaseLedge"",
                    ""type"": ""Button"",
                    ""id"": ""c2e10a5f-fc7a-4cdd-bf50-69b6bbdd3068"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Glide"",
                    ""type"": ""Button"",
                    ""id"": ""492c375e-d956-4dc4-baf2-9103634a4980"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""150a03ca-45c1-4c4d-a2bc-2ff654430455"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Grind Brake"",
                    ""type"": ""Button"",
                    ""id"": ""3362cb5a-99f1-4128-be17-aa7d01b20423"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""75373f86-c773-445a-b392-95a356385998"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""23b0fae0-283a-49c3-a232-61836dc54ef2"",
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
                    ""id"": ""8f0ab74f-7e2d-45c3-8921-3f8c9b9d8b22"",
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
                    ""id"": ""a7cda5d4-5e91-4dd0-9761-54cde24240ec"",
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
                    ""id"": ""e69d2c57-f959-464e-9bfd-fba807f72773"",
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
                    ""id"": ""5a90ac70-dd0f-4f2e-ac06-4e035967c5e4"",
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
                    ""id"": ""fa308585-20ca-4c49-9c96-69e9f586f3ca"",
                    ""path"": ""<GamePad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6a4a9c17-19d9-46f1-b8ef-500c5b13367d"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""741e2118-d481-4e98-9d77-c0cc23f6a2d2"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc8ccc11-5ff6-4100-8019-c3b478bb288a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b47364ae-9092-48aa-8d75-7ae0e5fddb97"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Spin"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2185602a-c6ff-4945-8c95-ef56267cebb2"",
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
                    ""id"": ""ea1e1992-5f19-4797-b750-189f1f7d5f95"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2bfee48-44a3-4eed-95cd-d6c9163265ed"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f59b0759-ea4e-4f62-b095-72dcaa8c9e0f"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""669a6623-bc96-41c3-8eed-97339b3147ba"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PickAndDrop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a339f3cc-5a1c-45d3-a0aa-3f056418d975"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PickAndDrop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c6a5d87-9f0a-4555-82dc-967f405d9ab7"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24c6a40d-bebd-403a-b081-b7831a67e7d5"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da269196-99a9-48f5-9740-4625ac30cad3"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Stomp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b1500e7d-46ef-4b5e-a991-d4311ba4d135"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Stomp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""186c002a-e618-4638-9889-021012cc1130"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AirDive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6ab2ba8-8b8a-42fb-90c5-fdb505baaa6c"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AirDive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9a4e391-b83a-4ca9-af14-67dacb4cbd88"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ReleaseLedge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f144d81-7011-43cc-8e51-15b406403bbf"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ReleaseLedge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20c90d0f-91c2-41b2-8633-a402b41cfd92"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6cc5a9ee-bf3e-4906-85d1-985a6f72506a"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ede21232-3fe2-41a0-8ea4-8001cf0030b6"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.05,y=0.05)"",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41201a57-b3fb-40a8-a633-b8213fe86cc5"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=135,y=135)"",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b94cd4a-0c3f-4f44-8acc-acf65dc29098"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Glide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""96757090-55fe-425f-b2cc-3920359d78ff"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Glide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d327dfed-a7f4-4949-877d-d6aa49e6a9a2"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""189d02cc-1720-4a52-8efe-b3c9f94125e3"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8401c498-4aa3-404a-910d-9b53fb866f61"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grind Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64ba2ebf-92cd-471e-a307-9b47780359b1"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grind Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28d7989a-6748-4bfb-931f-f667fd19f0ad"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Swim Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f26add7-00db-486c-84f1-107f264ab54c"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Swim Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Movement = m_Gameplay.FindAction("Movement", throwIfNotFound: true);
        m_Gameplay_Look = m_Gameplay.FindAction("Look", throwIfNotFound: true);
        m_Gameplay_Run = m_Gameplay.FindAction("Run", throwIfNotFound: true);
        m_Gameplay_Dive = m_Gameplay.FindAction("Dive", throwIfNotFound: true);
        m_Gameplay_SwimUp = m_Gameplay.FindAction("Swim Up", throwIfNotFound: true);
        m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
        m_Gameplay_PickAndDrop = m_Gameplay.FindAction("PickAndDrop", throwIfNotFound: true);
        m_Gameplay_Crouch = m_Gameplay.FindAction("Crouch", throwIfNotFound: true);
        m_Gameplay_Spin = m_Gameplay.FindAction("Spin", throwIfNotFound: true);
        m_Gameplay_Stomp = m_Gameplay.FindAction("Stomp", throwIfNotFound: true);
        m_Gameplay_AirDive = m_Gameplay.FindAction("AirDive", throwIfNotFound: true);
        m_Gameplay_ReleaseLedge = m_Gameplay.FindAction("ReleaseLedge", throwIfNotFound: true);
        m_Gameplay_Glide = m_Gameplay.FindAction("Glide", throwIfNotFound: true);
        m_Gameplay_Dash = m_Gameplay.FindAction("Dash", throwIfNotFound: true);
        m_Gameplay_GrindBrake = m_Gameplay.FindAction("Grind Brake", throwIfNotFound: true);
        m_Gameplay_Pause = m_Gameplay.FindAction("Pause", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_Gameplay_Movement;
    private readonly InputAction m_Gameplay_Look;
    private readonly InputAction m_Gameplay_Run;
    private readonly InputAction m_Gameplay_Dive;
    private readonly InputAction m_Gameplay_SwimUp;
    private readonly InputAction m_Gameplay_Jump;
    private readonly InputAction m_Gameplay_PickAndDrop;
    private readonly InputAction m_Gameplay_Crouch;
    private readonly InputAction m_Gameplay_Spin;
    private readonly InputAction m_Gameplay_Stomp;
    private readonly InputAction m_Gameplay_AirDive;
    private readonly InputAction m_Gameplay_ReleaseLedge;
    private readonly InputAction m_Gameplay_Glide;
    private readonly InputAction m_Gameplay_Dash;
    private readonly InputAction m_Gameplay_GrindBrake;
    private readonly InputAction m_Gameplay_Pause;
    public struct GameplayActions
    {
        private @PlayerInputActions m_Wrapper;
        public GameplayActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Gameplay_Movement;
        public InputAction @Look => m_Wrapper.m_Gameplay_Look;
        public InputAction @Run => m_Wrapper.m_Gameplay_Run;
        public InputAction @Dive => m_Wrapper.m_Gameplay_Dive;
        public InputAction @SwimUp => m_Wrapper.m_Gameplay_SwimUp;
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputAction @PickAndDrop => m_Wrapper.m_Gameplay_PickAndDrop;
        public InputAction @Crouch => m_Wrapper.m_Gameplay_Crouch;
        public InputAction @Spin => m_Wrapper.m_Gameplay_Spin;
        public InputAction @Stomp => m_Wrapper.m_Gameplay_Stomp;
        public InputAction @AirDive => m_Wrapper.m_Gameplay_AirDive;
        public InputAction @ReleaseLedge => m_Wrapper.m_Gameplay_ReleaseLedge;
        public InputAction @Glide => m_Wrapper.m_Gameplay_Glide;
        public InputAction @Dash => m_Wrapper.m_Gameplay_Dash;
        public InputAction @GrindBrake => m_Wrapper.m_Gameplay_GrindBrake;
        public InputAction @Pause => m_Wrapper.m_Gameplay_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
            @Run.started += instance.OnRun;
            @Run.performed += instance.OnRun;
            @Run.canceled += instance.OnRun;
            @Dive.started += instance.OnDive;
            @Dive.performed += instance.OnDive;
            @Dive.canceled += instance.OnDive;
            @SwimUp.started += instance.OnSwimUp;
            @SwimUp.performed += instance.OnSwimUp;
            @SwimUp.canceled += instance.OnSwimUp;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @PickAndDrop.started += instance.OnPickAndDrop;
            @PickAndDrop.performed += instance.OnPickAndDrop;
            @PickAndDrop.canceled += instance.OnPickAndDrop;
            @Crouch.started += instance.OnCrouch;
            @Crouch.performed += instance.OnCrouch;
            @Crouch.canceled += instance.OnCrouch;
            @Spin.started += instance.OnSpin;
            @Spin.performed += instance.OnSpin;
            @Spin.canceled += instance.OnSpin;
            @Stomp.started += instance.OnStomp;
            @Stomp.performed += instance.OnStomp;
            @Stomp.canceled += instance.OnStomp;
            @AirDive.started += instance.OnAirDive;
            @AirDive.performed += instance.OnAirDive;
            @AirDive.canceled += instance.OnAirDive;
            @ReleaseLedge.started += instance.OnReleaseLedge;
            @ReleaseLedge.performed += instance.OnReleaseLedge;
            @ReleaseLedge.canceled += instance.OnReleaseLedge;
            @Glide.started += instance.OnGlide;
            @Glide.performed += instance.OnGlide;
            @Glide.canceled += instance.OnGlide;
            @Dash.started += instance.OnDash;
            @Dash.performed += instance.OnDash;
            @Dash.canceled += instance.OnDash;
            @GrindBrake.started += instance.OnGrindBrake;
            @GrindBrake.performed += instance.OnGrindBrake;
            @GrindBrake.canceled += instance.OnGrindBrake;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
        }

        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
            @Run.started -= instance.OnRun;
            @Run.performed -= instance.OnRun;
            @Run.canceled -= instance.OnRun;
            @Dive.started -= instance.OnDive;
            @Dive.performed -= instance.OnDive;
            @Dive.canceled -= instance.OnDive;
            @SwimUp.started -= instance.OnSwimUp;
            @SwimUp.performed -= instance.OnSwimUp;
            @SwimUp.canceled -= instance.OnSwimUp;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @PickAndDrop.started -= instance.OnPickAndDrop;
            @PickAndDrop.performed -= instance.OnPickAndDrop;
            @PickAndDrop.canceled -= instance.OnPickAndDrop;
            @Crouch.started -= instance.OnCrouch;
            @Crouch.performed -= instance.OnCrouch;
            @Crouch.canceled -= instance.OnCrouch;
            @Spin.started -= instance.OnSpin;
            @Spin.performed -= instance.OnSpin;
            @Spin.canceled -= instance.OnSpin;
            @Stomp.started -= instance.OnStomp;
            @Stomp.performed -= instance.OnStomp;
            @Stomp.canceled -= instance.OnStomp;
            @AirDive.started -= instance.OnAirDive;
            @AirDive.performed -= instance.OnAirDive;
            @AirDive.canceled -= instance.OnAirDive;
            @ReleaseLedge.started -= instance.OnReleaseLedge;
            @ReleaseLedge.performed -= instance.OnReleaseLedge;
            @ReleaseLedge.canceled -= instance.OnReleaseLedge;
            @Glide.started -= instance.OnGlide;
            @Glide.performed -= instance.OnGlide;
            @Glide.canceled -= instance.OnGlide;
            @Dash.started -= instance.OnDash;
            @Dash.performed -= instance.OnDash;
            @Dash.canceled -= instance.OnDash;
            @GrindBrake.started -= instance.OnGrindBrake;
            @GrindBrake.performed -= instance.OnGrindBrake;
            @GrindBrake.canceled -= instance.OnGrindBrake;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
        }

        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnDive(InputAction.CallbackContext context);
        void OnSwimUp(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnPickAndDrop(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnSpin(InputAction.CallbackContext context);
        void OnStomp(InputAction.CallbackContext context);
        void OnAirDive(InputAction.CallbackContext context);
        void OnReleaseLedge(InputAction.CallbackContext context);
        void OnGlide(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnGrindBrake(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
}
