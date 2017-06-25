using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CreateBuildng  {
    [MenuItem("Assets/Shop/Building")]
    public static void SetBuildng()
    {
        Building asset = ScriptableObject.CreateInstance<Building>();
        AssetDatabase.CreateAsset(asset, "Assets/NewBuilding.asset");
        AssetDatabase.SaveAssets();
        EditorUtility.FocusProjectWindow();
        Selection.activeObject = asset;
    }
	
}
