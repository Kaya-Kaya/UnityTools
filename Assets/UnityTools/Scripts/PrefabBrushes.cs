using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Prefab Brushes", menuName = "UnityTools/Prefab Brushes", order = 1)]
public class PrefabBrushes : ScriptableObject
{
    [Serializable]
    public struct Prefab{
        public string name;
        public GameObject prefab;
    }

    public Prefab[] prefabs;
}
