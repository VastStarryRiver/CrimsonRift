#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class LuaCallCSWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(LuaCallCS);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 55, 3, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "GetGameObject", _m_GetGameObject_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTransform", _m_GetTransform_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "OpenUIPrefabPanel", _m_OpenUIPrefabPanel_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CloseUIPrefabPanel", _m_CloseUIPrefabPanel_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateUIGameObject", _m_CreateUIGameObject_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetComponent", _m_GetComponent_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddComponent", _m_AddComponent_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "Clone", _m_Clone_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetActive", _m_SetActive_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "HideAllChildren", _m_HideAllChildren_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PlayPositionAnimation", _m_PlayPositionAnimation_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PlayRotationAnimation", _m_PlayRotationAnimation_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PlayScaleAnimation", _m_PlayScaleAnimation_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PlayAlphaAnimation", _m_PlayAlphaAnimation_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PlayCurveAnimation", _m_PlayCurveAnimation_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ShowAnimationByTime", _m_ShowAnimationByTime_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "PlayAnimation", _m_PlayAnimation_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "StopAnimation", _m_StopAnimation_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddClickListener", _m_AddClickListener_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReleaseClickListener", _m_ReleaseClickListener_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddDownListener", _m_AddDownListener_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReleaseDownListener", _m_ReleaseDownListener_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddUpListener", _m_AddUpListener_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReleaseUpListener", _m_ReleaseUpListener_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddDoubleClickListener", _m_AddDoubleClickListener_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReleaseDoubleClickListener", _m_ReleaseDoubleClickListener_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddLongPressListener", _m_AddLongPressListener_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReleaseLongPressListener", _m_ReleaseLongPressListener_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TextureToCircle", _m_TextureToCircle_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "TextureToOriginal", _m_TextureToOriginal_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetSpriteImage", _m_SetSpriteImage_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetSpriteImageNativeSize", _m_SetSpriteImageNativeSize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetTextureRawImage", _m_SetTextureRawImage_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetTextureRawImageNativeSize", _m_SetTextureRawImageNativeSize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetGray", _m_SetGray_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetText", _m_SetText_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetParent", _m_SetParent_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetSdkMsgManager", _m_GetSdkMsgManager_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "AddInputFieldListener", _m_AddInputFieldListener_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetConfigData", _m_GetConfigData_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ReadFileByteData", _m_ReadFileByteData_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CreateFileByBytes", _m_CreateFileByBytes_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SerializeData", _m_SerializeData_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "CompressByteData", _m_CompressByteData_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DecompressByteData", _m_DecompressByteData_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "EncryptByteData", _m_EncryptByteData_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DecryptByteData", _m_DecryptByteData_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SaveSafeFile", _m_SaveSafeFile_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "FormatFileByteSize", _m_FormatFileByteSize_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetTextureRectByAtlasName", _m_GetTextureRectByAtlasName_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "GetStringByKey", _m_GetStringByKey_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SendMessage", _m_SendMessage_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "BindReceiveMessage", _m_BindReceiveMessage_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "UnbindReceiveMessage", _m_UnbindReceiveMessage_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MainUICamera", _g_get_MainUICamera);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MainUIRoot", _g_get_MainUIRoot);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "MainSceneCamera", _g_get_MainSceneCamera);
            
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "LuaCallCS does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetGameObject_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)) 
                {
                    string _childPath = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = LuaCallCS.GetGameObject( _childPath );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = LuaCallCS.GetGameObject( _obj, _childPath );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                        var gen_ret = LuaCallCS.GetGameObject( _obj );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCallCS.GetGameObject!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTransform_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = LuaCallCS.GetTransform( _obj, _childPath );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                        var gen_ret = LuaCallCS.GetTransform( _obj );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCallCS.GetTransform!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_OpenUIPrefabPanel_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.GameObject>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.GameObject _prefab = (UnityEngine.GameObject)translator.GetObject(L, 1, typeof(UnityEngine.GameObject));
                    string _luaPath = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = LuaCallCS.OpenUIPrefabPanel( _prefab, _luaPath );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string _prefabPath = LuaAPI.lua_tostring(L, 1);
                    string _luaPath = LuaAPI.lua_tostring(L, 2);
                    int _layer = LuaAPI.xlua_tointeger(L, 3);
                    
                        var gen_ret = LuaCallCS.OpenUIPrefabPanel( _prefabPath, _luaPath, _layer );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCallCS.OpenUIPrefabPanel!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CloseUIPrefabPanel_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _prefabName = LuaAPI.lua_tostring(L, 1);
                    
                    LuaCallCS.CloseUIPrefabPanel( _prefabName );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateUIGameObject_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& translator.Assignable<UnityEngine.Object>(L, 4)) 
                {
                    string _prefabPath = LuaAPI.lua_tostring(L, 1);
                    string _prefabName = LuaAPI.lua_tostring(L, 2);
                    int _layer = LuaAPI.xlua_tointeger(L, 3);
                    UnityEngine.Object _parent = (UnityEngine.Object)translator.GetObject(L, 4, typeof(UnityEngine.Object));
                    
                        var gen_ret = LuaCallCS.CreateUIGameObject( _prefabPath, _prefabName, _layer, _parent );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    string _prefabPath = LuaAPI.lua_tostring(L, 1);
                    string _prefabName = LuaAPI.lua_tostring(L, 2);
                    int _layer = LuaAPI.xlua_tointeger(L, 3);
                    
                        var gen_ret = LuaCallCS.CreateUIGameObject( _prefabPath, _prefabName, _layer );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _prefabPath = LuaAPI.lua_tostring(L, 1);
                    string _prefabName = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = LuaCallCS.CreateUIGameObject( _prefabPath, _prefabName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCallCS.CreateUIGameObject!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetComponent_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    string _componentName = LuaAPI.lua_tostring(L, 3);
                    
                        var gen_ret = LuaCallCS.GetComponent( _obj, _childPath, _componentName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddComponent_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    string _componentName = LuaAPI.lua_tostring(L, 3);
                    
                        var gen_ret = LuaCallCS.AddComponent( _obj, _childPath, _componentName );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clone_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Object>(L, 3)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Object _parent = (UnityEngine.Object)translator.GetObject(L, 3, typeof(UnityEngine.Object));
                    
                        var gen_ret = LuaCallCS.Clone( _obj, _name, _parent );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _name = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = LuaCallCS.Clone( _obj, _name );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                        var gen_ret = LuaCallCS.Clone( _obj );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCallCS.Clone!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetActive_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    bool _isActive = LuaAPI.lua_toboolean(L, 2);
                    
                    LuaCallCS.SetActive( _obj, _isActive );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                    LuaCallCS.SetActive( _obj );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    bool _isActive = LuaAPI.lua_toboolean(L, 3);
                    
                    LuaCallCS.SetActive( _obj, _childPath, _isActive );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    
                    LuaCallCS.SetActive( _obj, _childPath );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCallCS.SetActive!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_HideAllChildren_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Transform _transform = (UnityEngine.Transform)translator.GetObject(L, 1, typeof(UnityEngine.Transform));
                    
                    LuaCallCS.HideAllChildren( _transform );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PlayPositionAnimation_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 10&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TFUNCTION)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& translator.Assignable<DG.Tweening.LoopType>(L, 9)&& translator.Assignable<DG.Tweening.Ease>(L, 10)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _startPos;translator.Get(L, 3, out _startPos);
                    UnityEngine.Vector3 _endPos;translator.Get(L, 4, out _endPos);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 5);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 6, typeof(XLua.LuaFunction));
                    float _delay = (float)LuaAPI.lua_tonumber(L, 7);
                    int _loopCount = LuaAPI.xlua_tointeger(L, 8);
                    DG.Tweening.LoopType _loopType;translator.Get(L, 9, out _loopType);
                    DG.Tweening.Ease _moveWay;translator.Get(L, 10, out _moveWay);
                    
                        var gen_ret = LuaCallCS.PlayPositionAnimation( _obj, _childPath, _startPos, _endPos, _duration, _luaFunc, _delay, _loopCount, _loopType, _moveWay );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TFUNCTION)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& translator.Assignable<DG.Tweening.LoopType>(L, 9)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _startPos;translator.Get(L, 3, out _startPos);
                    UnityEngine.Vector3 _endPos;translator.Get(L, 4, out _endPos);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 5);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 6, typeof(XLua.LuaFunction));
                    float _delay = (float)LuaAPI.lua_tonumber(L, 7);
                    int _loopCount = LuaAPI.xlua_tointeger(L, 8);
                    DG.Tweening.LoopType _loopType;translator.Get(L, 9, out _loopType);
                    
                        var gen_ret = LuaCallCS.PlayPositionAnimation( _obj, _childPath, _startPos, _endPos, _duration, _luaFunc, _delay, _loopCount, _loopType );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TFUNCTION)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _startPos;translator.Get(L, 3, out _startPos);
                    UnityEngine.Vector3 _endPos;translator.Get(L, 4, out _endPos);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 5);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 6, typeof(XLua.LuaFunction));
                    float _delay = (float)LuaAPI.lua_tonumber(L, 7);
                    int _loopCount = LuaAPI.xlua_tointeger(L, 8);
                    
                        var gen_ret = LuaCallCS.PlayPositionAnimation( _obj, _childPath, _startPos, _endPos, _duration, _luaFunc, _delay, _loopCount );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TFUNCTION)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _startPos;translator.Get(L, 3, out _startPos);
                    UnityEngine.Vector3 _endPos;translator.Get(L, 4, out _endPos);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 5);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 6, typeof(XLua.LuaFunction));
                    float _delay = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        var gen_ret = LuaCallCS.PlayPositionAnimation( _obj, _childPath, _startPos, _endPos, _duration, _luaFunc, _delay );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TFUNCTION)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _startPos;translator.Get(L, 3, out _startPos);
                    UnityEngine.Vector3 _endPos;translator.Get(L, 4, out _endPos);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 5);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 6, typeof(XLua.LuaFunction));
                    
                        var gen_ret = LuaCallCS.PlayPositionAnimation( _obj, _childPath, _startPos, _endPos, _duration, _luaFunc );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _startPos;translator.Get(L, 3, out _startPos);
                    UnityEngine.Vector3 _endPos;translator.Get(L, 4, out _endPos);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = LuaCallCS.PlayPositionAnimation( _obj, _childPath, _startPos, _endPos, _duration );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _startPos;translator.Get(L, 3, out _startPos);
                    UnityEngine.Vector3 _endPos;translator.Get(L, 4, out _endPos);
                    
                        var gen_ret = LuaCallCS.PlayPositionAnimation( _obj, _childPath, _startPos, _endPos );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 3)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _startPos;translator.Get(L, 3, out _startPos);
                    
                        var gen_ret = LuaCallCS.PlayPositionAnimation( _obj, _childPath, _startPos );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = LuaCallCS.PlayPositionAnimation( _obj, _childPath );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                        var gen_ret = LuaCallCS.PlayPositionAnimation( _obj );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCallCS.PlayPositionAnimation!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PlayRotationAnimation_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 10&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TFUNCTION)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& translator.Assignable<DG.Tweening.LoopType>(L, 9)&& translator.Assignable<DG.Tweening.Ease>(L, 10)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _startRot;translator.Get(L, 3, out _startRot);
                    UnityEngine.Vector3 _endRot;translator.Get(L, 4, out _endRot);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 5);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 6, typeof(XLua.LuaFunction));
                    float _delay = (float)LuaAPI.lua_tonumber(L, 7);
                    int _loopCount = LuaAPI.xlua_tointeger(L, 8);
                    DG.Tweening.LoopType _loopType;translator.Get(L, 9, out _loopType);
                    DG.Tweening.Ease _moveWay;translator.Get(L, 10, out _moveWay);
                    
                        var gen_ret = LuaCallCS.PlayRotationAnimation( _obj, _childPath, _startRot, _endRot, _duration, _luaFunc, _delay, _loopCount, _loopType, _moveWay );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TFUNCTION)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& translator.Assignable<DG.Tweening.LoopType>(L, 9)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _startRot;translator.Get(L, 3, out _startRot);
                    UnityEngine.Vector3 _endRot;translator.Get(L, 4, out _endRot);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 5);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 6, typeof(XLua.LuaFunction));
                    float _delay = (float)LuaAPI.lua_tonumber(L, 7);
                    int _loopCount = LuaAPI.xlua_tointeger(L, 8);
                    DG.Tweening.LoopType _loopType;translator.Get(L, 9, out _loopType);
                    
                        var gen_ret = LuaCallCS.PlayRotationAnimation( _obj, _childPath, _startRot, _endRot, _duration, _luaFunc, _delay, _loopCount, _loopType );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TFUNCTION)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _startRot;translator.Get(L, 3, out _startRot);
                    UnityEngine.Vector3 _endRot;translator.Get(L, 4, out _endRot);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 5);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 6, typeof(XLua.LuaFunction));
                    float _delay = (float)LuaAPI.lua_tonumber(L, 7);
                    int _loopCount = LuaAPI.xlua_tointeger(L, 8);
                    
                        var gen_ret = LuaCallCS.PlayRotationAnimation( _obj, _childPath, _startRot, _endRot, _duration, _luaFunc, _delay, _loopCount );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TFUNCTION)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _startRot;translator.Get(L, 3, out _startRot);
                    UnityEngine.Vector3 _endRot;translator.Get(L, 4, out _endRot);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 5);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 6, typeof(XLua.LuaFunction));
                    float _delay = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        var gen_ret = LuaCallCS.PlayRotationAnimation( _obj, _childPath, _startRot, _endRot, _duration, _luaFunc, _delay );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TFUNCTION)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _startRot;translator.Get(L, 3, out _startRot);
                    UnityEngine.Vector3 _endRot;translator.Get(L, 4, out _endRot);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 5);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 6, typeof(XLua.LuaFunction));
                    
                        var gen_ret = LuaCallCS.PlayRotationAnimation( _obj, _childPath, _startRot, _endRot, _duration, _luaFunc );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _startRot;translator.Get(L, 3, out _startRot);
                    UnityEngine.Vector3 _endRot;translator.Get(L, 4, out _endRot);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = LuaCallCS.PlayRotationAnimation( _obj, _childPath, _startRot, _endRot, _duration );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _startRot;translator.Get(L, 3, out _startRot);
                    UnityEngine.Vector3 _endRot;translator.Get(L, 4, out _endRot);
                    
                        var gen_ret = LuaCallCS.PlayRotationAnimation( _obj, _childPath, _startRot, _endRot );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 3)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _startRot;translator.Get(L, 3, out _startRot);
                    
                        var gen_ret = LuaCallCS.PlayRotationAnimation( _obj, _childPath, _startRot );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = LuaCallCS.PlayRotationAnimation( _obj, _childPath );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                        var gen_ret = LuaCallCS.PlayRotationAnimation( _obj );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCallCS.PlayRotationAnimation!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PlayScaleAnimation_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 10&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TFUNCTION)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& translator.Assignable<DG.Tweening.LoopType>(L, 9)&& translator.Assignable<DG.Tweening.Ease>(L, 10)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _startScale;translator.Get(L, 3, out _startScale);
                    UnityEngine.Vector3 _endScale;translator.Get(L, 4, out _endScale);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 5);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 6, typeof(XLua.LuaFunction));
                    float _delay = (float)LuaAPI.lua_tonumber(L, 7);
                    int _loopCount = LuaAPI.xlua_tointeger(L, 8);
                    DG.Tweening.LoopType _loopType;translator.Get(L, 9, out _loopType);
                    DG.Tweening.Ease _moveWay;translator.Get(L, 10, out _moveWay);
                    
                        var gen_ret = LuaCallCS.PlayScaleAnimation( _obj, _childPath, _startScale, _endScale, _duration, _luaFunc, _delay, _loopCount, _loopType, _moveWay );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TFUNCTION)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& translator.Assignable<DG.Tweening.LoopType>(L, 9)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _startScale;translator.Get(L, 3, out _startScale);
                    UnityEngine.Vector3 _endScale;translator.Get(L, 4, out _endScale);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 5);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 6, typeof(XLua.LuaFunction));
                    float _delay = (float)LuaAPI.lua_tonumber(L, 7);
                    int _loopCount = LuaAPI.xlua_tointeger(L, 8);
                    DG.Tweening.LoopType _loopType;translator.Get(L, 9, out _loopType);
                    
                        var gen_ret = LuaCallCS.PlayScaleAnimation( _obj, _childPath, _startScale, _endScale, _duration, _luaFunc, _delay, _loopCount, _loopType );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TFUNCTION)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _startScale;translator.Get(L, 3, out _startScale);
                    UnityEngine.Vector3 _endScale;translator.Get(L, 4, out _endScale);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 5);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 6, typeof(XLua.LuaFunction));
                    float _delay = (float)LuaAPI.lua_tonumber(L, 7);
                    int _loopCount = LuaAPI.xlua_tointeger(L, 8);
                    
                        var gen_ret = LuaCallCS.PlayScaleAnimation( _obj, _childPath, _startScale, _endScale, _duration, _luaFunc, _delay, _loopCount );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TFUNCTION)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _startScale;translator.Get(L, 3, out _startScale);
                    UnityEngine.Vector3 _endScale;translator.Get(L, 4, out _endScale);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 5);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 6, typeof(XLua.LuaFunction));
                    float _delay = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        var gen_ret = LuaCallCS.PlayScaleAnimation( _obj, _childPath, _startScale, _endScale, _duration, _luaFunc, _delay );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TFUNCTION)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _startScale;translator.Get(L, 3, out _startScale);
                    UnityEngine.Vector3 _endScale;translator.Get(L, 4, out _endScale);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 5);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 6, typeof(XLua.LuaFunction));
                    
                        var gen_ret = LuaCallCS.PlayScaleAnimation( _obj, _childPath, _startScale, _endScale, _duration, _luaFunc );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _startScale;translator.Get(L, 3, out _startScale);
                    UnityEngine.Vector3 _endScale;translator.Get(L, 4, out _endScale);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = LuaCallCS.PlayScaleAnimation( _obj, _childPath, _startScale, _endScale, _duration );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 3)&& translator.Assignable<UnityEngine.Vector3>(L, 4)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _startScale;translator.Get(L, 3, out _startScale);
                    UnityEngine.Vector3 _endScale;translator.Get(L, 4, out _endScale);
                    
                        var gen_ret = LuaCallCS.PlayScaleAnimation( _obj, _childPath, _startScale, _endScale );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.Vector3>(L, 3)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.Vector3 _startScale;translator.Get(L, 3, out _startScale);
                    
                        var gen_ret = LuaCallCS.PlayScaleAnimation( _obj, _childPath, _startScale );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = LuaCallCS.PlayScaleAnimation( _obj, _childPath );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                        var gen_ret = LuaCallCS.PlayScaleAnimation( _obj );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCallCS.PlayScaleAnimation!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PlayAlphaAnimation_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 10&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TFUNCTION)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& translator.Assignable<DG.Tweening.LoopType>(L, 9)&& translator.Assignable<DG.Tweening.Ease>(L, 10)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    float _startAlpha = (float)LuaAPI.lua_tonumber(L, 3);
                    float _endAlpha = (float)LuaAPI.lua_tonumber(L, 4);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 5);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 6, typeof(XLua.LuaFunction));
                    float _delay = (float)LuaAPI.lua_tonumber(L, 7);
                    int _loopCount = LuaAPI.xlua_tointeger(L, 8);
                    DG.Tweening.LoopType _loopType;translator.Get(L, 9, out _loopType);
                    DG.Tweening.Ease _moveWay;translator.Get(L, 10, out _moveWay);
                    
                        var gen_ret = LuaCallCS.PlayAlphaAnimation( _obj, _childPath, _startAlpha, _endAlpha, _duration, _luaFunc, _delay, _loopCount, _loopType, _moveWay );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TFUNCTION)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& translator.Assignable<DG.Tweening.LoopType>(L, 9)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    float _startAlpha = (float)LuaAPI.lua_tonumber(L, 3);
                    float _endAlpha = (float)LuaAPI.lua_tonumber(L, 4);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 5);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 6, typeof(XLua.LuaFunction));
                    float _delay = (float)LuaAPI.lua_tonumber(L, 7);
                    int _loopCount = LuaAPI.xlua_tointeger(L, 8);
                    DG.Tweening.LoopType _loopType;translator.Get(L, 9, out _loopType);
                    
                        var gen_ret = LuaCallCS.PlayAlphaAnimation( _obj, _childPath, _startAlpha, _endAlpha, _duration, _luaFunc, _delay, _loopCount, _loopType );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TFUNCTION)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    float _startAlpha = (float)LuaAPI.lua_tonumber(L, 3);
                    float _endAlpha = (float)LuaAPI.lua_tonumber(L, 4);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 5);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 6, typeof(XLua.LuaFunction));
                    float _delay = (float)LuaAPI.lua_tonumber(L, 7);
                    int _loopCount = LuaAPI.xlua_tointeger(L, 8);
                    
                        var gen_ret = LuaCallCS.PlayAlphaAnimation( _obj, _childPath, _startAlpha, _endAlpha, _duration, _luaFunc, _delay, _loopCount );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TFUNCTION)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 7)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    float _startAlpha = (float)LuaAPI.lua_tonumber(L, 3);
                    float _endAlpha = (float)LuaAPI.lua_tonumber(L, 4);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 5);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 6, typeof(XLua.LuaFunction));
                    float _delay = (float)LuaAPI.lua_tonumber(L, 7);
                    
                        var gen_ret = LuaCallCS.PlayAlphaAnimation( _obj, _childPath, _startAlpha, _endAlpha, _duration, _luaFunc, _delay );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)&& (LuaAPI.lua_isnil(L, 6) || LuaAPI.lua_type(L, 6) == LuaTypes.LUA_TFUNCTION)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    float _startAlpha = (float)LuaAPI.lua_tonumber(L, 3);
                    float _endAlpha = (float)LuaAPI.lua_tonumber(L, 4);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 5);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 6, typeof(XLua.LuaFunction));
                    
                        var gen_ret = LuaCallCS.PlayAlphaAnimation( _obj, _childPath, _startAlpha, _endAlpha, _duration, _luaFunc );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 5)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    float _startAlpha = (float)LuaAPI.lua_tonumber(L, 3);
                    float _endAlpha = (float)LuaAPI.lua_tonumber(L, 4);
                    float _duration = (float)LuaAPI.lua_tonumber(L, 5);
                    
                        var gen_ret = LuaCallCS.PlayAlphaAnimation( _obj, _childPath, _startAlpha, _endAlpha, _duration );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    float _startAlpha = (float)LuaAPI.lua_tonumber(L, 3);
                    float _endAlpha = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = LuaCallCS.PlayAlphaAnimation( _obj, _childPath, _startAlpha, _endAlpha );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    float _startAlpha = (float)LuaAPI.lua_tonumber(L, 3);
                    
                        var gen_ret = LuaCallCS.PlayAlphaAnimation( _obj, _childPath, _startAlpha );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = LuaCallCS.PlayAlphaAnimation( _obj, _childPath );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                        var gen_ret = LuaCallCS.PlayAlphaAnimation( _obj );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCallCS.PlayAlphaAnimation!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PlayCurveAnimation_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 10&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TTABLE)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& (LuaAPI.lua_isnil(L, 5) || LuaAPI.lua_type(L, 5) == LuaTypes.LUA_TFUNCTION)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<DG.Tweening.PathType>(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& translator.Assignable<DG.Tweening.LoopType>(L, 9)&& translator.Assignable<DG.Tweening.Ease>(L, 10)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    XLua.LuaTable _posTable = (XLua.LuaTable)translator.GetObject(L, 3, typeof(XLua.LuaTable));
                    float _duration = (float)LuaAPI.lua_tonumber(L, 4);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 5, typeof(XLua.LuaFunction));
                    float _delay = (float)LuaAPI.lua_tonumber(L, 6);
                    DG.Tweening.PathType _pathType;translator.Get(L, 7, out _pathType);
                    int _loopCount = LuaAPI.xlua_tointeger(L, 8);
                    DG.Tweening.LoopType _loopType;translator.Get(L, 9, out _loopType);
                    DG.Tweening.Ease _moveWay;translator.Get(L, 10, out _moveWay);
                    
                        var gen_ret = LuaCallCS.PlayCurveAnimation( _obj, _childPath, _posTable, _duration, _luaFunc, _delay, _pathType, _loopCount, _loopType, _moveWay );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 9&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TTABLE)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& (LuaAPI.lua_isnil(L, 5) || LuaAPI.lua_type(L, 5) == LuaTypes.LUA_TFUNCTION)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<DG.Tweening.PathType>(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)&& translator.Assignable<DG.Tweening.LoopType>(L, 9)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    XLua.LuaTable _posTable = (XLua.LuaTable)translator.GetObject(L, 3, typeof(XLua.LuaTable));
                    float _duration = (float)LuaAPI.lua_tonumber(L, 4);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 5, typeof(XLua.LuaFunction));
                    float _delay = (float)LuaAPI.lua_tonumber(L, 6);
                    DG.Tweening.PathType _pathType;translator.Get(L, 7, out _pathType);
                    int _loopCount = LuaAPI.xlua_tointeger(L, 8);
                    DG.Tweening.LoopType _loopType;translator.Get(L, 9, out _loopType);
                    
                        var gen_ret = LuaCallCS.PlayCurveAnimation( _obj, _childPath, _posTable, _duration, _luaFunc, _delay, _pathType, _loopCount, _loopType );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 8&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TTABLE)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& (LuaAPI.lua_isnil(L, 5) || LuaAPI.lua_type(L, 5) == LuaTypes.LUA_TFUNCTION)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<DG.Tweening.PathType>(L, 7)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 8)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    XLua.LuaTable _posTable = (XLua.LuaTable)translator.GetObject(L, 3, typeof(XLua.LuaTable));
                    float _duration = (float)LuaAPI.lua_tonumber(L, 4);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 5, typeof(XLua.LuaFunction));
                    float _delay = (float)LuaAPI.lua_tonumber(L, 6);
                    DG.Tweening.PathType _pathType;translator.Get(L, 7, out _pathType);
                    int _loopCount = LuaAPI.xlua_tointeger(L, 8);
                    
                        var gen_ret = LuaCallCS.PlayCurveAnimation( _obj, _childPath, _posTable, _duration, _luaFunc, _delay, _pathType, _loopCount );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 7&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TTABLE)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& (LuaAPI.lua_isnil(L, 5) || LuaAPI.lua_type(L, 5) == LuaTypes.LUA_TFUNCTION)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)&& translator.Assignable<DG.Tweening.PathType>(L, 7)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    XLua.LuaTable _posTable = (XLua.LuaTable)translator.GetObject(L, 3, typeof(XLua.LuaTable));
                    float _duration = (float)LuaAPI.lua_tonumber(L, 4);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 5, typeof(XLua.LuaFunction));
                    float _delay = (float)LuaAPI.lua_tonumber(L, 6);
                    DG.Tweening.PathType _pathType;translator.Get(L, 7, out _pathType);
                    
                        var gen_ret = LuaCallCS.PlayCurveAnimation( _obj, _childPath, _posTable, _duration, _luaFunc, _delay, _pathType );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 6&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TTABLE)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& (LuaAPI.lua_isnil(L, 5) || LuaAPI.lua_type(L, 5) == LuaTypes.LUA_TFUNCTION)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 6)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    XLua.LuaTable _posTable = (XLua.LuaTable)translator.GetObject(L, 3, typeof(XLua.LuaTable));
                    float _duration = (float)LuaAPI.lua_tonumber(L, 4);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 5, typeof(XLua.LuaFunction));
                    float _delay = (float)LuaAPI.lua_tonumber(L, 6);
                    
                        var gen_ret = LuaCallCS.PlayCurveAnimation( _obj, _childPath, _posTable, _duration, _luaFunc, _delay );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TTABLE)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)&& (LuaAPI.lua_isnil(L, 5) || LuaAPI.lua_type(L, 5) == LuaTypes.LUA_TFUNCTION)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    XLua.LuaTable _posTable = (XLua.LuaTable)translator.GetObject(L, 3, typeof(XLua.LuaTable));
                    float _duration = (float)LuaAPI.lua_tonumber(L, 4);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 5, typeof(XLua.LuaFunction));
                    
                        var gen_ret = LuaCallCS.PlayCurveAnimation( _obj, _childPath, _posTable, _duration, _luaFunc );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TTABLE)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    XLua.LuaTable _posTable = (XLua.LuaTable)translator.GetObject(L, 3, typeof(XLua.LuaTable));
                    float _duration = (float)LuaAPI.lua_tonumber(L, 4);
                    
                        var gen_ret = LuaCallCS.PlayCurveAnimation( _obj, _childPath, _posTable, _duration );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TTABLE)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    XLua.LuaTable _posTable = (XLua.LuaTable)translator.GetObject(L, 3, typeof(XLua.LuaTable));
                    
                        var gen_ret = LuaCallCS.PlayCurveAnimation( _obj, _childPath, _posTable );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    
                        var gen_ret = LuaCallCS.PlayCurveAnimation( _obj, _childPath );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                        var gen_ret = LuaCallCS.PlayCurveAnimation( _obj );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCallCS.PlayCurveAnimation!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ShowAnimationByTime_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    string _animName = LuaAPI.lua_tostring(L, 3);
                    float _time = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    LuaCallCS.ShowAnimationByTime( _obj, _childPath, _animName, _time );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    string _animName = LuaAPI.lua_tostring(L, 3);
                    
                    LuaCallCS.ShowAnimationByTime( _obj, _childPath, _animName );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    
                    LuaCallCS.ShowAnimationByTime( _obj, _childPath );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                    LuaCallCS.ShowAnimationByTime( _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCallCS.ShowAnimationByTime!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PlayAnimation_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 5&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.WrapMode>(L, 4)&& (LuaAPI.lua_isnil(L, 5) || LuaAPI.lua_type(L, 5) == LuaTypes.LUA_TFUNCTION)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    string _animName = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.WrapMode _wrapMode;translator.Get(L, 4, out _wrapMode);
                    XLua.LuaFunction _callBack = (XLua.LuaFunction)translator.GetObject(L, 5, typeof(XLua.LuaFunction));
                    
                    LuaCallCS.PlayAnimation( _obj, _childPath, _animName, _wrapMode, _callBack );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& translator.Assignable<UnityEngine.WrapMode>(L, 4)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    string _animName = LuaAPI.lua_tostring(L, 3);
                    UnityEngine.WrapMode _wrapMode;translator.Get(L, 4, out _wrapMode);
                    
                    LuaCallCS.PlayAnimation( _obj, _childPath, _animName, _wrapMode );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    string _animName = LuaAPI.lua_tostring(L, 3);
                    
                    LuaCallCS.PlayAnimation( _obj, _childPath, _animName );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    
                    LuaCallCS.PlayAnimation( _obj, _childPath );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                    LuaCallCS.PlayAnimation( _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCallCS.PlayAnimation!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_StopAnimation_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    string _animName = LuaAPI.lua_tostring(L, 3);
                    
                    LuaCallCS.StopAnimation( _obj, _childPath, _animName );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    
                    LuaCallCS.StopAnimation( _obj, _childPath );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                    LuaCallCS.StopAnimation( _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCallCS.StopAnimation!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddClickListener_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 3, typeof(XLua.LuaFunction));
                    
                    LuaCallCS.AddClickListener( _obj, _childPath, _luaFunc );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReleaseClickListener_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                    LuaCallCS.ReleaseClickListener( _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddDownListener_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 2, typeof(XLua.LuaFunction));
                    
                    LuaCallCS.AddDownListener( _obj, _luaFunc );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReleaseDownListener_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                    LuaCallCS.ReleaseDownListener( _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddUpListener_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 2, typeof(XLua.LuaFunction));
                    
                    LuaCallCS.AddUpListener( _obj, _luaFunc );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReleaseUpListener_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                    LuaCallCS.ReleaseUpListener( _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddDoubleClickListener_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 2, typeof(XLua.LuaFunction));
                    
                    LuaCallCS.AddDoubleClickListener( _obj, _luaFunc );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReleaseDoubleClickListener_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                    LuaCallCS.ReleaseDoubleClickListener( _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddLongPressListener_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 2, typeof(XLua.LuaFunction));
                    
                    LuaCallCS.AddLongPressListener( _obj, _luaFunc );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReleaseLongPressListener_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                    LuaCallCS.ReleaseLongPressListener( _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TextureToCircle_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    bool _isSetNativeSize = LuaAPI.lua_toboolean(L, 2);
                    
                    LuaCallCS.TextureToCircle( _obj, _isSetNativeSize );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                    LuaCallCS.TextureToCircle( _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCallCS.TextureToCircle!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_TextureToOriginal_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 2)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    bool _isSetNativeSize = LuaAPI.lua_toboolean(L, 2);
                    
                    LuaCallCS.TextureToOriginal( _obj, _isSetNativeSize );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                    LuaCallCS.TextureToOriginal( _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCallCS.TextureToOriginal!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetSpriteImage_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    string _spritePath = LuaAPI.lua_tostring(L, 3);
                    bool _isSetNativeSize = LuaAPI.lua_toboolean(L, 4);
                    
                    LuaCallCS.SetSpriteImage( _obj, _childPath, _spritePath, _isSetNativeSize );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    string _spritePath = LuaAPI.lua_tostring(L, 3);
                    
                    LuaCallCS.SetSpriteImage( _obj, _childPath, _spritePath );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    
                    LuaCallCS.SetSpriteImage( _obj, _childPath );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                    LuaCallCS.SetSpriteImage( _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCallCS.SetSpriteImage!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetSpriteImageNativeSize_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.UI.Image _image = (UnityEngine.UI.Image)translator.GetObject(L, 1, typeof(UnityEngine.UI.Image));
                    
                    LuaCallCS.SetSpriteImageNativeSize( _image );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTextureRawImage_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    string _texturePath = LuaAPI.lua_tostring(L, 3);
                    bool _isSetNativeSize = LuaAPI.lua_toboolean(L, 4);
                    
                    LuaCallCS.SetTextureRawImage( _obj, _childPath, _texturePath, _isSetNativeSize );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    string _texturePath = LuaAPI.lua_tostring(L, 3);
                    
                    LuaCallCS.SetTextureRawImage( _obj, _childPath, _texturePath );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    
                    LuaCallCS.SetTextureRawImage( _obj, _childPath );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                    LuaCallCS.SetTextureRawImage( _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCallCS.SetTextureRawImage!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetTextureRawImageNativeSize_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.UI.RawImage _rawImage = (UnityEngine.UI.RawImage)translator.GetObject(L, 1, typeof(UnityEngine.UI.RawImage));
                    
                    LuaCallCS.SetTextureRawImageNativeSize( _rawImage );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetGray_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 4)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    bool _isGray = LuaAPI.lua_toboolean(L, 3);
                    bool _isMask = LuaAPI.lua_toboolean(L, 4);
                    
                    LuaCallCS.SetGray( _obj, _childPath, _isGray, _isMask );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TBOOLEAN == LuaAPI.lua_type(L, 3)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    bool _isGray = LuaAPI.lua_toboolean(L, 3);
                    
                    LuaCallCS.SetGray( _obj, _childPath, _isGray );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    
                    LuaCallCS.SetGray( _obj, _childPath );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                    LuaCallCS.SetGray( _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCallCS.SetGray!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetText_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    string _des = LuaAPI.lua_tostring(L, 3);
                    
                    LuaCallCS.SetText( _obj, _childPath, _des );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& translator.Assignable<UnityEngine.Object>(L, 1)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    
                    LuaCallCS.SetText( _obj, _childPath );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1&& translator.Assignable<UnityEngine.Object>(L, 1)) 
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    
                    LuaCallCS.SetText( _obj );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCallCS.SetText!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetParent_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    UnityEngine.Transform _parent = (UnityEngine.Transform)translator.GetObject(L, 2, typeof(UnityEngine.Transform));
                    
                    LuaCallCS.SetParent( _obj, _parent );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetSdkMsgManager_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    
                        var gen_ret = LuaCallCS.GetSdkMsgManager(  );
                        translator.Push(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddInputFieldListener_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Object _obj = (UnityEngine.Object)translator.GetObject(L, 1, typeof(UnityEngine.Object));
                    string _childPath = LuaAPI.lua_tostring(L, 2);
                    XLua.LuaFunction _luaFunc = (XLua.LuaFunction)translator.GetObject(L, 3, typeof(XLua.LuaFunction));
                    
                    LuaCallCS.AddInputFieldListener( _obj, _childPath, _luaFunc );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetConfigData_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 2)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    string _configName = LuaAPI.lua_tostring(L, 1);
                    int _id = LuaAPI.xlua_tointeger(L, 2);
                    string _name = LuaAPI.lua_tostring(L, 3);
                    
                        var gen_ret = LuaCallCS.GetConfigData( _configName, _id, _name );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 1) || LuaAPI.lua_type(L, 1) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TSTRING)) 
                {
                    string _configName = LuaAPI.lua_tostring(L, 1);
                    string _index = LuaAPI.lua_tostring(L, 2);
                    string _name = LuaAPI.lua_tostring(L, 3);
                    
                        var gen_ret = LuaCallCS.GetConfigData( _configName, _index, _name );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCallCS.GetConfigData!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ReadFileByteData_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _path = LuaAPI.lua_tostring(L, 1);
                    
                        var gen_ret = LuaCallCS.ReadFileByteData( _path );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CreateFileByBytes_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _path = LuaAPI.lua_tostring(L, 1);
                    byte[] _inputBytes = LuaAPI.lua_tobytes(L, 2);
                    
                    LuaCallCS.CreateFileByBytes( _path, _inputBytes );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SerializeData_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    object _data = translator.GetObject(L, 1, typeof(object));
                    
                        var gen_ret = LuaCallCS.SerializeData( _data );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CompressByteData_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    byte[] _inputBytes = LuaAPI.lua_tobytes(L, 1);
                    
                        var gen_ret = LuaCallCS.CompressByteData( _inputBytes );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DecompressByteData_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    byte[] _inputBytes = LuaAPI.lua_tobytes(L, 1);
                    
                        var gen_ret = LuaCallCS.DecompressByteData( _inputBytes );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_EncryptByteData_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    byte[] _inputBytes = LuaAPI.lua_tobytes(L, 1);
                    byte[] _key = LuaAPI.lua_tobytes(L, 2);
                    byte[] _iv = LuaAPI.lua_tobytes(L, 3);
                    
                        var gen_ret = LuaCallCS.EncryptByteData( _inputBytes, _key, _iv );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DecryptByteData_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    byte[] _inputBytes = LuaAPI.lua_tobytes(L, 1);
                    byte[] _key = LuaAPI.lua_tobytes(L, 2);
                    byte[] _iv = LuaAPI.lua_tobytes(L, 3);
                    
                        var gen_ret = LuaCallCS.DecryptByteData( _inputBytes, _key, _iv );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SaveSafeFile_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    object _data = translator.GetObject(L, 1, typeof(object));
                    string _filePath = LuaAPI.lua_tostring(L, 2);
                    
                    LuaCallCS.SaveSafeFile( _data, _filePath );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_FormatFileByteSize_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    long _bytes = LuaAPI.lua_toint64(L, 1);
                    
                        var gen_ret = LuaCallCS.FormatFileByteSize( _bytes );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetTextureRectByAtlasName_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _atlasName = LuaAPI.lua_tostring(L, 1);
                    string _textureName = LuaAPI.lua_tostring(L, 2);
                    float[] _rect;
                    
                        var gen_ret = LuaCallCS.GetTextureRectByAtlasName( _atlasName, _textureName, out _rect );
                        LuaAPI.lua_pushboolean(L, gen_ret);
                    translator.Push(L, _rect);
                        
                    
                    
                    
                    return 2;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_GetStringByKey_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)) 
                {
                    int _id = LuaAPI.xlua_tointeger(L, 1);
                    
                        var gen_ret = LuaCallCS.GetStringByKey( _id );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                if(gen_param_count >= 1&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 1)&& (LuaTypes.LUA_TNONE == LuaAPI.lua_type(L, 2) || translator.Assignable<object>(L, 2))) 
                {
                    int _id = LuaAPI.xlua_tointeger(L, 1);
                    object[] _param = translator.GetParams<object>(L, 2);
                    
                        var gen_ret = LuaCallCS.GetStringByKey( _id, _param );
                        LuaAPI.lua_pushstring(L, gen_ret);
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to LuaCallCS.GetStringByKey!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SendMessage_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _messageName = LuaAPI.lua_tostring(L, 1);
                    XLua.LuaTable _msg = (XLua.LuaTable)translator.GetObject(L, 2, typeof(XLua.LuaTable));
                    
                    LuaCallCS.SendMessage( _messageName, _msg );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_BindReceiveMessage_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _messageName = LuaAPI.lua_tostring(L, 1);
                    XLua.LuaFunction _luaFunction = (XLua.LuaFunction)translator.GetObject(L, 2, typeof(XLua.LuaFunction));
                    
                    LuaCallCS.BindReceiveMessage( _messageName, _luaFunction );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnbindReceiveMessage_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _messageName = LuaAPI.lua_tostring(L, 1);
                    XLua.LuaFunction _luaFunction = (XLua.LuaFunction)translator.GetObject(L, 2, typeof(XLua.LuaFunction));
                    
                    LuaCallCS.UnbindReceiveMessage( _messageName, _luaFunction );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MainUICamera(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, LuaCallCS.MainUICamera);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MainUIRoot(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, LuaCallCS.MainUIRoot);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_MainSceneCamera(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, LuaCallCS.MainSceneCamera);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
		
		
		
		
    }
}
