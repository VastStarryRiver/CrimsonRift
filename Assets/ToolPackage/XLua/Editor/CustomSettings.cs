using XLua;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public static class CustomSettings
{
    [LuaCallCSharp]
    public static IEnumerable<Type> LuaCallCSharp
    {
        get
        {
            List<Type> types = new List<Type>
            {
                typeof(Component),
                typeof(Transform),
                typeof(GameObject),
                typeof(Camera),
                typeof(Rigidbody),
                typeof(Behaviour),
                typeof(TrackedReference),
                typeof(Physics),
                typeof(Collider),
                typeof(Time),
                typeof(Shader),
                typeof(Renderer),
                typeof(Screen),
                typeof(CameraClearFlags),
                typeof(AudioClip),
                typeof(ParticleSystem),
                typeof(LightType),
                typeof(SleepTimeout),
                typeof(Animator),
                typeof(KeyCode),
                typeof(Space),
                typeof(BoxCollider),
                typeof(MeshCollider),
                typeof(SphereCollider),
                typeof(CharacterController),
                typeof(CapsuleCollider),
                typeof(Animation),
                typeof(AnimationState),
                typeof(AnimationBlendMode),
                typeof(QueueMode),
                typeof(PlayMode),
                typeof(WrapMode),
                typeof(RenderSettings),
                typeof(SkinWeights),
                typeof(RenderTexture),
                typeof(Canvas),
                typeof(CanvasScaler),
                typeof(GraphicRaycaster),
                typeof(RectTransform),
                typeof(RawImage),
                typeof(Image),
                typeof(TextMeshProUGUI),
                typeof(MaskableGraphic),
                typeof(MaskableGraphic.CullStateChangedEvent),
                typeof(Button),
                typeof(Button.ButtonClickedEvent),
                typeof(ScrollRect),
                typeof(ScrollRect.ScrollRectEvent),
                typeof(Dropdown),
                typeof(Dropdown.DropdownEvent),
                typeof(Dropdown.OptionData),
                typeof(Dropdown.OptionDataList),
                typeof(Toggle),
                typeof(Toggle.ToggleEvent),
                typeof(Slider),
                typeof(Slider.SliderEvent),
                typeof(Scrollbar),
                typeof(Scrollbar.ScrollEvent),
                typeof(TMP_InputField),
                typeof(TMP_InputField.OnChangeEvent),
                typeof(TMP_InputField.SubmitEvent),
                typeof(GridLayoutGroup),
                typeof(HorizontalLayoutGroup),
                typeof(VerticalLayoutGroup),
                typeof(Mask),
                typeof(RectMask2D),
                typeof(Ease),
                typeof(LoopType),
                typeof(PathType),

                //添加需要映射的自定义脚本
                typeof(UIMask),
                typeof(UIButton),
                typeof(UIInputField),
                typeof(LuaCallCS),
                typeof(PrefabInstance),
                typeof(SdkMsgManager),
                typeof(DataUtilityManager),
                typeof(DebugLogTool),
                typeof(CircleRawImage),
                typeof(CircleImage),
                typeof(LoopScrollList),
                typeof(PolygonImage),
                typeof(LanguageManager),
            };

            return types;
        }
    }

    //把LuaCallCSharp涉及到的delegate加到CSharpCallLua列表，后续可以直接用lua函数做callback
    [CSharpCallLua]
    public static List<Type> CSharpCallLua
    {
        get
        {
            List<Type> callBack = new List<Type>
            {
                typeof(Action),
                typeof(Action<bool>),
                typeof(Action<float>),
                typeof(Action<string>),
                typeof(Action<Vector2>),
                typeof(ScrollRect.ScrollRectEvent),
                typeof(Action<int, string>),
                typeof(Func<float, bool>),
            };

            return callBack;
        }
    }
}