using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementController : MonoBehaviour
{
    [SerializeField] private EnemyData _enemyData;
    
    private Transform _targetTransform;

    void Awake()
    {
        GetReferences();
    }

    private void GetReferences()
    {
        _targetTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        FollowTarget();
    }

    private void FollowTarget()
    {
        transform.position = Vector2.MoveTowards(transform.position, _targetTransform.position, _enemyData.Speed * Time.deltaTime);
    }
}
