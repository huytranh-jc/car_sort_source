// Đặt file này trong folder Editor (ví dụ: Assets/Editor/SpriteToPngWindow.cs)
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class SpriteToPngWindow : EditorWindow
{
    private Vector2 _scroll;
    private string _outputFolder = "Assets/ExtractedPNG";
    private bool _useSpriteName = true;
    private bool _overwrite = true;
    private bool _importAsSprite = false;
    private List<Sprite> _sprites = new List<Sprite>();

    [MenuItem("Tools/Sprite → PNG")]
    public static void Open()
    {
        var w = GetWindow<SpriteToPngWindow>("Sprite → PNG");
        w.minSize = new Vector2(380, 440);
        w.RefreshSelection();
    }

    private void OnSelectionChange()
    {
        RefreshSelection();
        Repaint();
    }

    private void RefreshSelection()
    {
        _sprites.Clear();
        foreach (var obj in Selection.objects)
        {
            if (obj is Sprite sp)
            {
                _sprites.Add(sp);
            }
            else if (obj is Texture2D)
            {
                // Nếu chọn texture, lấy tất cả sprite con trong nó
                string path = AssetDatabase.GetAssetPath(obj);
                foreach (var sub in AssetDatabase.LoadAllAssetsAtPath(path))
                    if (sub is Sprite s) _sprites.Add(s);
            }
        }
    }

    private void OnGUI()
    {
        EditorGUILayout.Space();
        EditorGUILayout.LabelField("Cấu hình", EditorStyles.boldLabel);

        EditorGUILayout.BeginHorizontal();
        _outputFolder = EditorGUILayout.TextField("Output Folder", _outputFolder);
        if (GUILayout.Button("...", GUILayout.Width(30)))
        {
            string picked = EditorUtility.OpenFolderPanel("Chọn folder output", Application.dataPath, "");
            if (!string.IsNullOrEmpty(picked) && picked.StartsWith(Application.dataPath))
                _outputFolder = "Assets" + picked.Substring(Application.dataPath.Length);
        }
        EditorGUILayout.EndHorizontal();

        _useSpriteName = EditorGUILayout.Toggle(
            new GUIContent("Đặt tên theo Sprite", "Bỏ chọn để thêm hậu tố _export"), _useSpriteName);
        _overwrite = EditorGUILayout.Toggle("Ghi đè nếu trùng", _overwrite);
        _importAsSprite = EditorGUILayout.Toggle(
            new GUIContent("Import PNG dạng Sprite", "Tự set Texture Type = Sprite (2D and UI) sau khi export"),
            _importAsSprite);

        EditorGUILayout.Space();
        EditorGUILayout.LabelField($"Sprite đang chọn: {_sprites.Count}", EditorStyles.boldLabel);

        _scroll = EditorGUILayout.BeginScrollView(_scroll, GUILayout.MaxHeight(180));
        if (_sprites.Count == 0)
        {
            EditorGUILayout.HelpBox("Chọn 1 hoặc nhiều Sprite trong Project window.", MessageType.Info);
        }
        else
        {
            foreach (var sp in _sprites)
            {
                EditorGUILayout.BeginHorizontal();
                EditorGUILayout.ObjectField(sp, typeof(Sprite), false);
                var r = sp.textureRect;
                EditorGUILayout.LabelField($"{(int)r.width}x{(int)r.height}", GUILayout.Width(80));
                EditorGUILayout.EndHorizontal();
            }
        }
        EditorGUILayout.EndScrollView();

        EditorGUILayout.Space();
        GUI.enabled = _sprites.Count > 0;
        if (GUILayout.Button("Export sang PNG", GUILayout.Height(34)))
            ExportAll();
        GUI.enabled = true;
    }

    private void ExportAll()
    {
        if (!Directory.Exists(_outputFolder))
        {
            Directory.CreateDirectory(_outputFolder);
            AssetDatabase.Refresh();
        }

        int ok = 0, fail = 0;
        var madeReadable = new HashSet<string>();
        var exportedPaths = new List<string>();

        try
        {
            for (int i = 0; i < _sprites.Count; i++)
            {
                var sp = _sprites[i];
                EditorUtility.DisplayProgressBar("Exporting PNG", sp.name, (float)i / _sprites.Count);

                if (sp.texture == null) { fail++; continue; }

                // Bảo đảm texture nguồn đọc được (tạm bật Read/Write)
                string srcPath = AssetDatabase.GetAssetPath(sp.texture);
                var importer = AssetImporter.GetAtPath(srcPath) as TextureImporter;
                if (importer != null && !importer.isReadable)
                {
                    importer.isReadable = true;
                    importer.SaveAndReimport();
                    madeReadable.Add(srcPath);
                }

                byte[] png = EncodeSpriteToPng(sp);
                if (png == null) { fail++; continue; }

                string baseName = _useSpriteName ? sp.name : sp.name + "_export";
                baseName = SanitizeFileName(baseName);
                string assetPath = $"{_outputFolder}/{baseName}.png";
                if (!_overwrite)
                    assetPath = AssetDatabase.GenerateUniqueAssetPath(assetPath);

                File.WriteAllBytes(assetPath, png);
                exportedPaths.Add(assetPath);
                ok++;
            }
        }
        finally
        {
            // Trả lại trạng thái Read/Write ban đầu
            foreach (var p in madeReadable)
            {
                var imp = AssetImporter.GetAtPath(p) as TextureImporter;
                if (imp != null) { imp.isReadable = false; imp.SaveAndReimport(); }
            }
            EditorUtility.ClearProgressBar();
            AssetDatabase.Refresh();
        }

        // Set Texture Type = Sprite cho các PNG vừa export (nếu chọn)
        if (_importAsSprite)
        {
            foreach (var p in exportedPaths)
            {
                var imp = AssetImporter.GetAtPath(p) as TextureImporter;
                if (imp != null)
                {
                    imp.textureType = TextureImporterType.Sprite;
                    imp.SaveAndReimport();
                }
            }
        }

        Debug.Log($"[Sprite→PNG] Hoàn tất. Thành công: {ok}, lỗi: {fail}. Output: {_outputFolder}");
        EditorUtility.DisplayDialog("Sprite → PNG",
            $"Thành công: {ok}\nLỗi: {fail}\nFolder: {_outputFolder}", "OK");
    }

    private byte[] EncodeSpriteToPng(Sprite sp)
    {
        var rect = sp.textureRect;
        int w = Mathf.Max(1, (int)rect.width);
        int h = Mathf.Max(1, (int)rect.height);

        Color[] pixels;
        try
        {
            pixels = sp.texture.GetPixels((int)rect.x, (int)rect.y, w, h);
        }
        catch (UnityException e)
        {
            Debug.LogError($"Không đọc được pixel của '{sp.name}': {e.Message}. " +
                           "Bật Read/Write Enabled cho texture nguồn.");
            return null;
        }

        var tex = new Texture2D(w, h, TextureFormat.RGBA32, false);
        tex.SetPixels(pixels);
        tex.Apply();
        byte[] png = tex.EncodeToPNG();
        Object.DestroyImmediate(tex);
        return png;
    }

    private static string SanitizeFileName(string name)
    {
        foreach (var c in Path.GetInvalidFileNameChars())
            name = name.Replace(c, '_');
        return name;
    }
}