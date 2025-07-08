using System.IO;
using XLua;
using System.Collections.Generic;



public class LuaManager : Singleton<LuaManager>
{
    public LuaEnv m_LuaEnv = null;//Lua的虚拟机
    public Dictionary<string, LuaTable> m_luaClassList;//所有预制体对应的lua脚本



    public void Play()
    {
        if (m_LuaEnv != null)
        {
            return;
        }

        m_luaClassList = new Dictionary<string, LuaTable>();

        m_LuaEnv = new LuaEnv();//虚拟机初始化


        m_LuaEnv.AddLoader((ref string path) => {
            string suffix = Path.GetExtension(path);
            string path2 = DataUtilityManager.m_localRootPath + "Lua/" + path;

            if (suffix != ".lua")
            {
                path2 = path2 + ".lua";
            }

            if (File.Exists(path2))
            {
                return File.ReadAllBytes(path2);
            }

            return null;
        });

        m_LuaEnv.DoString("require('Workflow/Main')");//任意已经添加的搜索路径下的完整lua路径
    }

    public void Stop()
    {
        if (m_LuaEnv != null)
        {
            m_LuaEnv.Dispose();
            m_LuaEnv = null;
        }

        if(m_luaClassList != null)
        {
            m_luaClassList.Clear();
            m_luaClassList = null;
        }
    }

    public void Reset()
    {
        Stop();
        Play();
    }
}