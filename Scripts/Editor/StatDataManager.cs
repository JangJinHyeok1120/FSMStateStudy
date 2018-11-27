using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreateStatDataClass
{
    [MenuItem("Assets/FSM/StatData")]
    public static StatData CreateStatData()
    {
        StatData asset = ScriptableObject.CreateInstance<StatData>();
        AssetDatabase.CreateAsset(asset, "Assets/Data/StatData.asset");
        AssetDatabase.SaveAssets();
        return asset;
    }

    [MenuItem("Assets/FSM/GoblinStat")]
    public static GoblinStatData CreateGoblinStatData()
    {
        GoblinStatData asset = ScriptableObject.CreateInstance<GoblinStatData>();
        AssetDatabase.CreateAsset(asset, "Assets/Data/GoblinStat.asset");
        AssetDatabase.SaveAssets();
        return asset;
    }
}
