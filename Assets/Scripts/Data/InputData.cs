using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

[CreateAssetMenu(menuName = "TopDown / Input / Input Data")]
public class InputData : ScriptableObject
{
    [SerializeField] private float _horizontal;
    public float Horizontal { get { return _horizontal; } set { _horizontal = value; } }
    
    [SerializeField] private float _vertical;
    public float Vertical { get { return _vertical; } set { _vertical = value; } }
}
