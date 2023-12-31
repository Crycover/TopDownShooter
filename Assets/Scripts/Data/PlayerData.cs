using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TopDown / Player / Player Data")]
public class PlayerData : ScriptableObject
{
    [SerializeField] private float _speed;

    public float Speed { get { return _speed; } set {  _speed = value; } }
}
