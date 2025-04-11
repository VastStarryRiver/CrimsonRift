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
    public class DebugLogToolWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(DebugLogTool);
			Utils.BeginObjectRegister(type, L, translator, 0, 0, 0, 0);
			
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 8, 0, 0);
			Utils.RegisterFunc(L, Utils.CLS_IDX, "DebugRedLog", _m_DebugRedLog_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DebugYellowLog", _m_DebugYellowLog_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DebugBlueLog", _m_DebugBlueLog_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DebugGreenLog", _m_DebugGreenLog_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "DebugBlackLog", _m_DebugBlackLog_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "ShowDebugErrorLog", _m_ShowDebugErrorLog_xlua_st_);
            Utils.RegisterFunc(L, Utils.CLS_IDX, "InitDebugErrorLog", _m_InitDebugErrorLog_xlua_st_);
            
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            return LuaAPI.luaL_error(L, "DebugLogTool does not have a constructor!");
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DebugRedLog_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _log = LuaAPI.lua_tostring(L, 1);
                    
                    DebugLogTool.DebugRedLog( _log );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DebugYellowLog_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _log = LuaAPI.lua_tostring(L, 1);
                    
                    DebugLogTool.DebugYellowLog( _log );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DebugBlueLog_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _log = LuaAPI.lua_tostring(L, 1);
                    
                    DebugLogTool.DebugBlueLog( _log );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DebugGreenLog_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _log = LuaAPI.lua_tostring(L, 1);
                    
                    DebugLogTool.DebugGreenLog( _log );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DebugBlackLog_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    string _log = LuaAPI.lua_tostring(L, 1);
                    
                    DebugLogTool.DebugBlackLog( _log );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_ShowDebugErrorLog_xlua_st_(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
            
                
                {
                    string _logString = LuaAPI.lua_tostring(L, 1);
                    string _stackTrace = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.LogType _type;translator.Get(L, 3, out _type);
                    
                    DebugLogTool.ShowDebugErrorLog( _logString, _stackTrace, _type );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InitDebugErrorLog_xlua_st_(RealStatePtr L)
        {
		    try {
            
            
            
                
                {
                    
                    DebugLogTool.InitDebugErrorLog(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
