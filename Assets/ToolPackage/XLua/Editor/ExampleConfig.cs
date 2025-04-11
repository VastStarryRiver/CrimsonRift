/*
 * Tencent is pleased to support the open source community by making xLua available.
 * Copyright (C) 2016 THL A29 Limited, a Tencent company. All rights reserved.
 * Licensed under the MIT License (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
 * http://opensource.org/licenses/MIT
 * Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
*/

using System.Collections.Generic;
using System;
using XLua;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public static class ExampleConfig
{
    [LuaCallCSharp]
    public static List<Type> customTypeList = new List<Type>()
    {
        //添加需要映射的unity原生组件
        typeof(Component),
        typeof(Transform),
        typeof(GameObject),
        typeof(Camera),
        typeof(Rigidbody),
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
        typeof(AsyncOperation),
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
        typeof(AnimationClip),
        typeof(AnimationState),
        typeof(AnimationBlendMode),
        typeof(QueueMode),
        typeof(PlayMode),
        typeof(WrapMode),
        typeof(RenderSettings),
        typeof(SkinWeights),
        typeof(RenderTexture),
        typeof(Canvas),
        typeof(CanvasRenderer),
        typeof(CanvasScaler),
        typeof(GraphicRaycaster),
        typeof(RectTransform),
        typeof(RawImage),
        typeof(Image),
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
        typeof(GridLayoutGroup),
        typeof(HorizontalLayoutGroup),
        typeof(VerticalLayoutGroup),
        typeof(Mask),
        typeof(RectMask2D),

        //添加需要映射的自定义脚本
        typeof(LuaCallCS),
        typeof(UIButton),
        typeof(Ease),
        typeof(LoopType),
        typeof(PathType),
        typeof(PrefabInstance),
        typeof(DataUtilityManager),
        typeof(DebugLogTool),
        typeof(CircleRawImage),
        typeof(CircleImage),
        typeof(LoopScrollList),
        typeof(PolygonImage),
        typeof(UIMask),
        typeof(LanguageManager),
        typeof(TextMeshProUGUI),
    };

    //黑名单
    [BlackList]
    public static List<List<string>> BlackList = new List<List<string>>()  {
                new List<string>(){"System.Xml.XmlNodeList", "ItemOf"},
                new List<string>(){"UnityEngine.WWW", "movie"},
    #if UNITY_WEBGL
                new List<string>(){"UnityEngine.WWW", "threadPriority"},
    #endif
                new List<string>(){"UnityEngine.Texture2D", "alphaIsTransparency"},
                new List<string>(){"UnityEngine.Security", "GetChainOfTrustValue"},
                new List<string>(){"UnityEngine.CanvasRenderer", "onRequestRebuild"},
                new List<string>(){"UnityEngine.Light", "areaSize"},
                new List<string>(){"UnityEngine.Light", "lightmapBakeType"},
                new List<string>(){"UnityEngine.WWW", "MovieTexture"},
                new List<string>(){"UnityEngine.WWW", "GetMovieTexture"},
                new List<string>(){"UnityEngine.AnimatorOverrideController", "PerformOverrideClipListCleanup"},
    #if !UNITY_WEBPLAYER
                new List<string>(){"UnityEngine.Application", "ExternalEval"},
    #endif
                new List<string>(){"UnityEngine.GameObject", "networkView"}, //4.6.2 not support
                new List<string>(){"UnityEngine.Component", "networkView"},  //4.6.2 not support
                new List<string>(){"System.IO.FileInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections"},
                new List<string>(){"System.IO.FileInfo", "SetAccessControl", "System.Security.AccessControl.FileSecurity"},
                new List<string>(){"System.IO.DirectoryInfo", "GetAccessControl", "System.Security.AccessControl.AccessControlSections"},
                new List<string>(){"System.IO.DirectoryInfo", "SetAccessControl", "System.Security.AccessControl.DirectorySecurity"},
                new List<string>(){"System.IO.DirectoryInfo", "CreateSubdirectory", "System.String", "System.Security.AccessControl.DirectorySecurity"},
                new List<string>(){"System.IO.DirectoryInfo", "Create", "System.Security.AccessControl.DirectorySecurity"},
                new List<string>(){"UnityEngine.MonoBehaviour", "runInEditMode"},
            };

#if UNITY_2018_1_OR_NEWER
    [BlackList]
    public static Func<MemberInfo, bool> MethodFilter = (memberInfo) =>
    {
        if (memberInfo.DeclaringType.IsGenericType && memberInfo.DeclaringType.GetGenericTypeDefinition() == typeof(Dictionary<,>))
        {
            if (memberInfo.MemberType == MemberTypes.Constructor)
            {
                ConstructorInfo constructorInfo = memberInfo as ConstructorInfo;
                var parameterInfos = constructorInfo.GetParameters();
                if (parameterInfos.Length > 0)
                {
                    if (typeof(System.Collections.IEnumerable).IsAssignableFrom(parameterInfos[0].ParameterType))
                    {
                        return true;
                    }
                }
            }
            else if (memberInfo.MemberType == MemberTypes.Method)
            {
                var methodInfo = memberInfo as MethodInfo;
                if (methodInfo.Name == "TryAdd" || methodInfo.Name == "Remove" && methodInfo.GetParameters().Length == 2)
                {
                    return true;
                }
            }
        }
        return false;
    };
#endif
}