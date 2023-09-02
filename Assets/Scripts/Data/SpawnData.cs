using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TopDown / Enemy / Spawn Data")]
public class SpawnData : ScriptableObject
{
    public GameObject _enemyPrefab;

    [SerializeField] private float _interval;
    public float Interval { get { return _interval; } set { _interval = value; } }
}
