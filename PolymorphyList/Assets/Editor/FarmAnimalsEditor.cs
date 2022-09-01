using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
 
 [CustomEditor(typeof(PolymorphyList))]
 public class FarmAnimalsEditor : Editor
 {
     public override void OnInspectorGUI()
     {
        var script = (PolymorphyList)target;
 
        if(GUILayout.Button("Add Cow", GUILayout.Height(40)))
        {
            script.AddCow();
        }

        if(GUILayout.Button("Add Sheep", GUILayout.Height(40)))
        {
            script.AddSheep();
        }

        if(GUILayout.Button("Add Pig", GUILayout.Height(40)))
        {
            script.AddPig();
        }

        base.OnInspectorGUI();         
     }
 }