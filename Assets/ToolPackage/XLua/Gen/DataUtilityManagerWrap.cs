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
    public class DataUtilityManagerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DataUtilityManager);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 3, 6, 3);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "InitDirectory", _m_InitDirectory_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "SetWebQuestData", _m_SetWebQuestData_xlua_st_);
            
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "WebRootPath", _g_get_WebRootPath);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "WebIpv4Str", _g_get_WebIpv4Str);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "WebPortInt", _g_get_WebPortInt);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "m_platform", _g_get_m_platform);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "m_localRootPath", _g_get_m_localRootPath);
            Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "m_binPath", _g_get_m_binPath);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "m_platform", _s_set_m_platform);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "m_localRootPath", _s_set_m_localRootPath);
            Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "m_binPath", _s_set_m_binPath);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "DataUtilityManager does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InitDirectory_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _path = LuaAPI.lua_tostring(L, 1);
                    
                    DataUtilityManager.InitDirectory( _path );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetWebQuestData_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    UnityEngine.Networking.UnityWebRequest _requestHandler = (UnityEngine.Networking.UnityWebRequest)translator.GetObject(L, 1, typeof(UnityEngine.Networking.UnityWebRequest));
                    
                    DataUtilityManager.SetWebQuestData( ref _requestHandler );
                    translator.Push(L, _requestHandler);
                        
                    
                    
                    
                    return 1;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_WebRootPath(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DataUtilityManager.WebRootPath);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_WebIpv4Str(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DataUtilityManager.WebIpv4Str);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_WebPortInt(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.xlua_pushinteger(L, DataUtilityManager.WebPortInt);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_m_platform(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DataUtilityManager.m_platform);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_m_localRootPath(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DataUtilityManager.m_localRootPath);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_m_binPath(RealStatePtr L)
        {
		    try {
            
			    LuaAPI.lua_pushstring(L, DataUtilityManager.m_binPath);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_m_platform(RealStatePtr L)
        {
		    try {
                
			    DataUtilityManager.m_platform = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_m_localRootPath(RealStatePtr L)
        {
		    try {
                
			    DataUtilityManager.m_localRootPath = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_m_binPath(RealStatePtr L)
        {
		    try {
                
			    DataUtilityManager.m_binPath = LuaAPI.lua_tostring(L, 1);
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
