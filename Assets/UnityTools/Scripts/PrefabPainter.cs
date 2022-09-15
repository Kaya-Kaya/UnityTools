using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.PackageManager.UI;

#if UNITY_EDITOR

public class PrefabPainter : EditorWindow
{
    public PrefabBrushes prefabBrushes;
    bool mouseButton = true;
    bool paintButton = false;
    bool eraseButton = false;
    public Texture mouseIcon;
    public Texture paintBrushIcon;
    public Texture eraserIcon;
    public Texture2D notToggledBackground;
    public Texture2D toggledBackground;

    private static GUIStyle ToggleButtonStyleNormal = null;
    private static GUIStyle ToggleButtonStyleToggled = null;

    [MenuItem("UnityTools/Prefab Painter")]
    static void Init()
    {
        PrefabPainter window = (PrefabPainter)EditorWindow.GetWindow(typeof(PrefabPainter), false, "Prefab Painter");
        window.Show();
    }

    void OnPlacePrefab()
    {

    }

    void OnRemovePrefab()
    {

    }

    void OnGUI()
    {
        GUIStyleState toggled = new GUIStyleState();
        GUIStyleState notToggled = new GUIStyleState();
        GUIStyleState hover = new GUIStyleState();
        notToggled.background = notToggledBackground;
        ToggleButtonStyleNormal = new GUIStyle(GUI.skin.button)
        {
            fixedHeight = 48,
            normal = notToggled,
            hover = hover,
            margin = new RectOffset(0, 0, 0, 0)
        };
        toggled.background = toggledBackground;
        ToggleButtonStyleToggled = new GUIStyle(ToggleButtonStyleNormal);
        ToggleButtonStyleToggled.normal = toggled;

        GUILayout.BeginHorizontal();

        if (GUILayout.Button(mouseIcon, mouseButton ? ToggleButtonStyleToggled : ToggleButtonStyleNormal))
        {
            mouseButton = true;
            paintButton = false;
            eraseButton = false;
        }

        if (GUILayout.Button(paintBrushIcon, paintButton ? ToggleButtonStyleToggled : ToggleButtonStyleNormal))
        {
            paintButton = true;
            eraseButton = false;
            mouseButton = false;
        }

        
        if (GUILayout.Button(eraserIcon, eraseButton ? ToggleButtonStyleToggled : ToggleButtonStyleNormal))
        {
            eraseButton = true;
            paintButton = false;
            mouseButton = false;
        }
        

        GUILayout.EndHorizontal();
    }
}

#endif