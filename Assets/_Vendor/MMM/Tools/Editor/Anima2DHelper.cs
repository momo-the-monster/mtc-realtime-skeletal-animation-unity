using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MMM.Tools
{

    public class Anima2DHelper : EditorWindow
    {
        [MenuItem("Tools/Add Bone %&b")]
        internal static void AddBone()
        {
            Debug.LogFormat("AddBone");
            GameObject go = new GameObject("Bone");
            if (Selection.activeTransform != null)
            {
                go.transform.parent = Selection.activeTransform;
                go.transform.position = Selection.activeTransform.position;
                go.AddComponent<Anima2D.Bone2D>();
            }
        }
    }
}