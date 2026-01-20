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
    public class GameManagerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(GameManager);
			Utils.BeginObjectRegister(type, L, translator, 0, 15, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddCSEventListener", _m_AddCSEventListener);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveCSEventListener", _m_RemoveCSEventListener);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InvokeCSEventCallBack", _m_InvokeCSEventCallBack);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DelayCSCallFrames", _m_DelayCSCallFrames);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DelayCSCallSeconds", _m_DelayCSCallSeconds);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RepeatingCSCallFrames", _m_RepeatingCSCallFrames);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RepeatingCSCallSeconds", _m_RepeatingCSCallSeconds);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AddLuaEventListener", _m_AddLuaEventListener);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RemoveLuaEventListener", _m_RemoveLuaEventListener);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "InvokeLuaEventCallBack", _m_InvokeLuaEventCallBack);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DelayLuaCallFrames", _m_DelayLuaCallFrames);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "DelayLuaCallSeconds", _m_DelayLuaCallSeconds);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RepeatingLuaCallFrames", _m_RepeatingLuaCallFrames);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "RepeatingLuaCallSeconds", _m_RepeatingLuaCallSeconds);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "CancelInvokeByKey", _m_CancelInvokeByKey);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 1, 1);
			
			
            
			Utils.RegisterFunc(L, Utils.CLS_GETTER_IDX, "Instance", _g_get_Instance);
            
			Utils.RegisterFunc(L, Utils.CLS_SETTER_IDX, "Instance", _s_set_Instance);
            
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new GameManager();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to GameManager constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddCSEventListener(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameManager gen_to_be_invoked = (GameManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    System.Action<object> _callBack = translator.GetDelegate<System.Action<object>>(L, 3);
                    
                    gen_to_be_invoked.AddCSEventListener( _key, _callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveCSEventListener(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameManager gen_to_be_invoked = (GameManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    System.Action<object> _callBack = translator.GetDelegate<System.Action<object>>(L, 3);
                    
                    gen_to_be_invoked.RemoveCSEventListener( _key, _callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InvokeCSEventCallBack(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameManager gen_to_be_invoked = (GameManager)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<object>(L, 3)) 
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    object _arg = translator.GetObject(L, 3, typeof(object));
                    
                    gen_to_be_invoked.InvokeCSEventCallBack( _key, _arg );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 2&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)) 
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.InvokeCSEventCallBack( _key );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to GameManager.InvokeCSEventCallBack!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DelayCSCallFrames(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameManager gen_to_be_invoked = (GameManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    System.Action _callBack = translator.GetDelegate<System.Action>(L, 3);
                    int _frame = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.DelayCSCallFrames( _key, _callBack, _frame );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DelayCSCallSeconds(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameManager gen_to_be_invoked = (GameManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    System.Action _callBack = translator.GetDelegate<System.Action>(L, 3);
                    float _time = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    gen_to_be_invoked.DelayCSCallSeconds( _key, _callBack, _time );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RepeatingCSCallFrames(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameManager gen_to_be_invoked = (GameManager)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    System.Action _callBack = translator.GetDelegate<System.Action>(L, 3);
                    int _frame = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.RepeatingCSCallFrames( _key, _callBack, _frame );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action>(L, 3)) 
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    System.Action _callBack = translator.GetDelegate<System.Action>(L, 3);
                    
                    gen_to_be_invoked.RepeatingCSCallFrames( _key, _callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to GameManager.RepeatingCSCallFrames!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RepeatingCSCallSeconds(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameManager gen_to_be_invoked = (GameManager)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action>(L, 3)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    System.Action _callBack = translator.GetDelegate<System.Action>(L, 3);
                    float _time = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    gen_to_be_invoked.RepeatingCSCallSeconds( _key, _callBack, _time );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& translator.Assignable<System.Action>(L, 3)) 
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    System.Action _callBack = translator.GetDelegate<System.Action>(L, 3);
                    
                    gen_to_be_invoked.RepeatingCSCallSeconds( _key, _callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to GameManager.RepeatingCSCallSeconds!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AddLuaEventListener(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameManager gen_to_be_invoked = (GameManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    XLua.LuaFunction _callBack = (XLua.LuaFunction)translator.GetObject(L, 3, typeof(XLua.LuaFunction));
                    
                    gen_to_be_invoked.AddLuaEventListener( _key, _callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RemoveLuaEventListener(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameManager gen_to_be_invoked = (GameManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    XLua.LuaFunction _callBack = (XLua.LuaFunction)translator.GetObject(L, 3, typeof(XLua.LuaFunction));
                    
                    gen_to_be_invoked.RemoveLuaEventListener( _key, _callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_InvokeLuaEventCallBack(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameManager gen_to_be_invoked = (GameManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    object[] _param = translator.GetParams<object>(L, 3);
                    
                    gen_to_be_invoked.InvokeLuaEventCallBack( _key, _param );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DelayLuaCallFrames(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameManager gen_to_be_invoked = (GameManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    XLua.LuaFunction _callBack = (XLua.LuaFunction)translator.GetObject(L, 3, typeof(XLua.LuaFunction));
                    int _frame = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.DelayLuaCallFrames( _key, _callBack, _frame );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_DelayLuaCallSeconds(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameManager gen_to_be_invoked = (GameManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    XLua.LuaFunction _callBack = (XLua.LuaFunction)translator.GetObject(L, 3, typeof(XLua.LuaFunction));
                    float _time = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    gen_to_be_invoked.DelayLuaCallSeconds( _key, _callBack, _time );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RepeatingLuaCallFrames(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameManager gen_to_be_invoked = (GameManager)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TFUNCTION)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    XLua.LuaFunction _callBack = (XLua.LuaFunction)translator.GetObject(L, 3, typeof(XLua.LuaFunction));
                    int _frame = LuaAPI.xlua_tointeger(L, 4);
                    
                    gen_to_be_invoked.RepeatingLuaCallFrames( _key, _callBack, _frame );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TFUNCTION)) 
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    XLua.LuaFunction _callBack = (XLua.LuaFunction)translator.GetObject(L, 3, typeof(XLua.LuaFunction));
                    
                    gen_to_be_invoked.RepeatingLuaCallFrames( _key, _callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to GameManager.RepeatingLuaCallFrames!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_RepeatingLuaCallSeconds(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameManager gen_to_be_invoked = (GameManager)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 4&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TFUNCTION)&& LuaTypes.LUA_TNUMBER == LuaAPI.lua_type(L, 4)) 
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    XLua.LuaFunction _callBack = (XLua.LuaFunction)translator.GetObject(L, 3, typeof(XLua.LuaFunction));
                    float _time = (float)LuaAPI.lua_tonumber(L, 4);
                    
                    gen_to_be_invoked.RepeatingLuaCallSeconds( _key, _callBack, _time );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 3&& (LuaAPI.lua_isnil(L, 2) || LuaAPI.lua_type(L, 2) == LuaTypes.LUA_TSTRING)&& (LuaAPI.lua_isnil(L, 3) || LuaAPI.lua_type(L, 3) == LuaTypes.LUA_TFUNCTION)) 
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    XLua.LuaFunction _callBack = (XLua.LuaFunction)translator.GetObject(L, 3, typeof(XLua.LuaFunction));
                    
                    gen_to_be_invoked.RepeatingLuaCallSeconds( _key, _callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to GameManager.RepeatingLuaCallSeconds!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_CancelInvokeByKey(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                GameManager gen_to_be_invoked = (GameManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _key = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.CancelInvokeByKey( _key );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_Instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    translator.Push(L, GameManager.Instance);
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_Instance(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			    GameManager.Instance = (GameManager)translator.GetObject(L, 1, typeof(GameManager));
            
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
