using System.IO;
using UnityEditor.AssetImporters;
using UnityEngine;

[ScriptedImporter(1,".lua")]
public class LuaImporter : ScriptedImporter
{
    public override void OnImportAsset(AssetImportContext ctx)
    {
        string text = File.ReadAllText(ctx.assetPath);
        TextAsset asset = new TextAsset(text);
        ctx.AddObjectToAsset("main obj", asset);
        ctx.SetMainObject(asset);
    }
}