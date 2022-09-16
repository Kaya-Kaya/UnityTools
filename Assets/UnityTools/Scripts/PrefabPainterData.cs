using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Prefab Painter Data", menuName = "UnityTools/Prefab Painter Data", order = 1)]
public class PrefabPainterData : ScriptableObject
{
    [Serializable]
    public struct Prefab{
        public string name;
        public GameObject prefab;
    }

    public Prefab[] prefabs;
}
