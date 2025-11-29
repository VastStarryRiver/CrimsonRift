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
    public class AddressablesManagerWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(AddressablesManager);
			Utils.BeginObjectRegister(type, L, translator, 0, 12, 0, 0);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetWebQuestData", _m_SetWebQuestData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "PreLoadLuaBytes", _m_PreLoadLuaBytes);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AsyncLoadGameObject", _m_AsyncLoadGameObject);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AsyncLoadSprite", _m_AsyncLoadSprite);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AsyncLoadSpriteAtlas", _m_AsyncLoadSpriteAtlas);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AsyncLoadBinAsset", _m_AsyncLoadBinAsset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AsyncLoadTextAsset", _m_AsyncLoadTextAsset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AsyncLoadAudioClip", _m_AsyncLoadAudioClip);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AsyncLoadMaterial", _m_AsyncLoadMaterial);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "AsyncLoadScene", _m_AsyncLoadScene);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnLoadAsset", _m_UnLoadAsset);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "UnLoadScene", _m_UnLoadScene);
			
			
			
			
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					var gen_ret = new AddressablesManager();
					translator.Push(L, gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to AddressablesManager constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetWebQuestData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AddressablesManager gen_to_be_invoked = (AddressablesManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.SetWebQuestData(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_PreLoadLuaBytes(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AddressablesManager gen_to_be_invoked = (AddressablesManager)translator.FastGetCSObj(L, 1);
            
            
			    int gen_param_count = LuaAPI.lua_gettop(L);
            
                if(gen_param_count == 2&& translator.Assignable<System.Action>(L, 2)) 
                {
                    System.Action _callBack = translator.GetDelegate<System.Action>(L, 2);
                    
                    gen_to_be_invoked.PreLoadLuaBytes( _callBack );
                    
                    
                    
                    return 0;
                }
                if(gen_param_count == 1) 
                {
                    
                    gen_to_be_invoked.PreLoadLuaBytes(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
            return LuaAPI.luaL_error(L, "invalid arguments to AddressablesManager.PreLoadLuaBytes!");
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AsyncLoadGameObject(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AddressablesManager gen_to_be_invoked = (AddressablesManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _address = LuaAPI.lua_tostring(L, 2);
                    System.Action<UnityEngine.GameObject> _callBack = translator.GetDelegate<System.Action<UnityEngine.GameObject>>(L, 3);
                    
                    gen_to_be_invoked.AsyncLoadGameObject( _address, _callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AsyncLoadSprite(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AddressablesManager gen_to_be_invoked = (AddressablesManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _address = LuaAPI.lua_tostring(L, 2);
                    System.Action<UnityEngine.Sprite> _callBack = translator.GetDelegate<System.Action<UnityEngine.Sprite>>(L, 3);
                    
                    gen_to_be_invoked.AsyncLoadSprite( _address, _callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AsyncLoadSpriteAtlas(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AddressablesManager gen_to_be_invoked = (AddressablesManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _address = LuaAPI.lua_tostring(L, 2);
                    System.Action<UnityEngine.U2D.SpriteAtlas> _callBack = translator.GetDelegate<System.Action<UnityEngine.U2D.SpriteAtlas>>(L, 3);
                    
                    gen_to_be_invoked.AsyncLoadSpriteAtlas( _address, _callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AsyncLoadBinAsset(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AddressablesManager gen_to_be_invoked = (AddressablesManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _address = LuaAPI.lua_tostring(L, 2);
                    System.Action<BinAsset> _callBack = translator.GetDelegate<System.Action<BinAsset>>(L, 3);
                    
                    gen_to_be_invoked.AsyncLoadBinAsset( _address, _callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AsyncLoadTextAsset(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AddressablesManager gen_to_be_invoked = (AddressablesManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _address = LuaAPI.lua_tostring(L, 2);
                    System.Action<UnityEngine.TextAsset> _callBack = translator.GetDelegate<System.Action<UnityEngine.TextAsset>>(L, 3);
                    
                    gen_to_be_invoked.AsyncLoadTextAsset( _address, _callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AsyncLoadAudioClip(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AddressablesManager gen_to_be_invoked = (AddressablesManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _address = LuaAPI.lua_tostring(L, 2);
                    System.Action<UnityEngine.AudioClip> _callBack = translator.GetDelegate<System.Action<UnityEngine.AudioClip>>(L, 3);
                    
                    gen_to_be_invoked.AsyncLoadAudioClip( _address, _callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AsyncLoadMaterial(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AddressablesManager gen_to_be_invoked = (AddressablesManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _address = LuaAPI.lua_tostring(L, 2);
                    System.Action<UnityEngine.Material> _callBack = translator.GetDelegate<System.Action<UnityEngine.Material>>(L, 3);
                    
                    gen_to_be_invoked.AsyncLoadMaterial( _address, _callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_AsyncLoadScene(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AddressablesManager gen_to_be_invoked = (AddressablesManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _address = LuaAPI.lua_tostring(L, 2);
                    UnityEngine.SceneManagement.LoadSceneMode _loadSceneMode;translator.Get(L, 3, out _loadSceneMode);
                    System.Action<UnityEngine.SceneManagement.Scene> _callBack = translator.GetDelegate<System.Action<UnityEngine.SceneManagement.Scene>>(L, 4);
                    
                    gen_to_be_invoked.AsyncLoadScene( _address, _loadSceneMode, _callBack );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnLoadAsset(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AddressablesManager gen_to_be_invoked = (AddressablesManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    gen_to_be_invoked.UnLoadAsset(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_UnLoadScene(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                AddressablesManager gen_to_be_invoked = (AddressablesManager)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    string _address = LuaAPI.lua_tostring(L, 2);
                    
                    gen_to_be_invoked.UnLoadScene( _address );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + gen_e);
            }
            
        }
        
        
        
        
        
        
		
		
		
		
    }
}
