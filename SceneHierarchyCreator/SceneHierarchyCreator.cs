using UnityEditor;
using UnityEngine;

public static class SceneHierarchyCreator
{
    private static readonly string[] RootObjects =
    {
        "_SCENE",
        "_MANAGERS",
        "_SYSTEMS",
        "_PLAYER",
        "_ENVIRONMENT",
        "_INTERACTABLES",
        "_UI",
        "_CAMERAS",
        "_LIGHTING",
        "_AUDIO",
        "_VFX",
        "_DEBUG"
    };

    [MenuItem("Tools/Crear Hierarchy base")]
    public static void CreateBaseHierarchy()
    {
        if (!EditorUtility.DisplayDialog(
            "Crear Hierarchy base",
            "¿Quieres crear la estructura base de la Hierarchy?\n(No se duplicarán objetos existentes)",
            "Crear",
            "Cancelar"))
        {
            return;
        }

        foreach (string rootName in RootObjects)
        {
            if (GameObject.Find(rootName) == null)
            {
                GameObject root = new GameObject(rootName);
                Undo.RegisterCreatedObjectUndo(root, "Create " + rootName);
            }
        }

        Debug.Log("Hierarchy base creada correctamente");
    }
}
