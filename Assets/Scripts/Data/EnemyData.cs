using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TopDown / Enemy / Enemy Data")]
public class EnemyData : ScriptableObject
{
    [SerializeField] private float _speed;

    public float Speed { get { return _speed; } set { _speed = value; } }

    [SerializeField] private int _health;

    public int Health { get { return _health; } set { _health = value; } }
}
