using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(AV1Behaviour))]
public class AV1Editor : Editor
{
    int value;
    int index;
   
    public override void OnInspectorGUI()
    {
        AV1Behaviour AV1Behaviour = target as AV1Behaviour;
        
        
        value = EditorGUILayout.IntField("Valor", value);


        if (GUILayout.Button("Adicionar"))
        {
            AV1Behaviour.Add(AV1Behaviour.List.Count.ToString(), value);
        }
        EditorGUI.EndDisabledGroup();
        EditorGUILayout.LabelField("Remover", EditorStyles.boldLabel);
        index = EditorGUILayout.IntField("Valor", index);
        if (GUILayout.Button("Remover"))
        {
            AV1Behaviour.Remove(index);
        }

        EditorGUI.BeginDisabledGroup(true);
        EditorGUILayout.LabelField("Lista", EditorStyles.boldLabel);
        
        for (int i = 0; i < AV1Behaviour.List.Count; i++)
        {
            EditorGUILayout.FloatField(AV1Behaviour.List[i].key, AV1Behaviour.List[i].value);
        }  
        EditorGUILayout.LabelField("Adicionar", EditorStyles.boldLabel);
       
       
        
      

        
    }

}
