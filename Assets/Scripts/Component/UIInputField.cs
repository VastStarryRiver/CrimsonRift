using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TextCore;
using TMPro;
using LuaInterface;

public class UIInputField : TMP_InputField
{
    private LuaFunction m_onValueChangedFunc;

    protected override void Awake()
    {
        base.Awake();

        textComponent = transform.Find("Text Area/Text").GetComponent<TextMeshProUGUI>();
        textViewport = transform.Find("Text Area") as RectTransform;
        placeholder = transform.Find("Text Area/Placeholder").GetComponent<Graphic>();
        fontAsset = Resources.Load<TMP_FontAsset>("Fonts & Materials/NotoSansSC");

        SetEmojiSpriteAsset();

        onValueChanged.AddListener((str) =>
        {
            m_onValueChangedFunc?.Call(str);
        });
    }

    public void AddOnValueChangedListener(LuaFunction onValueChangedFunc)
    {
        m_onValueChangedFunc = onValueChangedFunc;
    }

    private void SetEmojiSpriteAsset()
    {
        TMP_SpriteAsset spriteAsset = Resources.Load<TMP_SpriteAsset>("Sprite Assets/emoji");

        for (int i = 0; i < spriteAsset.spriteGlyphTable.Count; i++)
        {
            TMP_SpriteGlyph glyph = spriteAsset.spriteGlyphTable[i];
            glyph.metrics = new GlyphMetrics(glyph.metrics.width, glyph.metrics.height, 0, glyph.metrics.height * 9 / 10, glyph.metrics.horizontalAdvance);
        }

        spriteAsset.UpdateLookupTables();

        textComponent.spriteAsset = spriteAsset;
    }
}