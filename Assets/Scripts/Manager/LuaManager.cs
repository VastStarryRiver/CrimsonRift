using XLua;
using System.Collections.Generic;
using System.IO;



public class LuaManager : Singleton<LuaManager>
{
    public LuaEnv m_luaEnv = null;//Lua的虚拟机
    public Dictionary<string, LuaTable> m_luaClassList;//所有预制体对应的lua脚本
    public Dictionary<string, byte[]> m_luaDataList;//所有lua脚本的byte[]数据



    public void Play()
    {
        if (m_luaEnv != null)
        {
            return;
        }

        m_luaClassList = new Dictionary<string, LuaTable>();

        m_luaEnv = new LuaEnv();//虚拟机初始化

        m_luaEnv.AddLoader((ref string filepath) =>
        {
            string key = Path.GetFileName(filepath);
            if (!key.Contains(".lua"))
            {
                key += ".lua";
            }

            if (m_luaDataList.ContainsKey(key))
            {
                return m_luaDataList[key];
            }

            return null;
        });

        m_luaEnv.DoString("require('Workflow/Main')");
    }

    public void Stop()
    {
        if (m_luaEnv != null)
        {
            m_luaEnv.Dispose();
            m_luaEnv = null;
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