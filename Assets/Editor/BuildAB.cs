using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEditor.Callbacks;
public static class AssetBundles
{
    [MenuItem("Build/Do")]
    public static void BuildAssetBundles()
    {
        var path = "AssetBundles" + DateTime.Now.ToString("_dd-MM-yyyy-HH-mm-ss");
        Directory.CreateDirectory(path);
        var manifest =  BuildPipeline.BuildAssetBundles(path,
        BuildAssetBundleOptions.AppendHashToAssetBundleName,
        BuildTarget.iOS);
    }

    //[PostProcessScene()]
    private static void EmptyMethod()
    {
    }
}















