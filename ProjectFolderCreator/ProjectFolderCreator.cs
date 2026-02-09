using UnityEditor;
using UnityEngine;
using System.IO;

public static class ProjectFolderCreator
{
    [MenuItem("Tools/Crear carpetas de proyecto")]
    public static void CreateProjectFolders()
    {
        CreateFolder("Assets", "_Project");
        CreateFolder("Assets", "_ThirdParty");
        CreateFolder("Assets", "_Sandbox");

        string projectPath = "Assets/_Project";

        string[] projectFolders =
        {
            "Scenes",
            "Scripts",
            "Prefabs",
            "Materials",
            "Textures",
            "Shaders",
            "Models",
            "Audio",
            "UI",
            "Animations",
            "Video",
            "Documents",
            "Settings"
        };

        foreach (string folder in projectFolders)
        {
            CreateFolder(projectPath, folder);
        }

        AssetDatabase.Refresh();
        Debug.Log("Estructura de carpetas creada correctamente");
    }

    private static void CreateFolder(string parent, string folderName)
    {
        string fullPath = Path.Combine(parent, folderName);

        if (!AssetDatabase.IsValidFolder(fullPath))
        {
            AssetDatabase.CreateFolder(parent, folderName);
        }
    }
}
