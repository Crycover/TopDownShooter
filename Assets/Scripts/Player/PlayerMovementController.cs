using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private PlayerData _playerData;
    [SerializeField] private InputData _inputData;

    private Rigidbody2D _rigidbody;
    private Animator _animator;
    private void Awake()
    {
        GetReferences();
    }

    private void GetReferences()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    void Start()
    {
        
    }

    private void Update()
    {
        Animations();
    }

    private void Animations()
    {
        if(Mathf.Abs(_inputData.Horizontal) > 0 || Mathf.Abs(_inputData.Vertical) > 0)
        {
            _animator.SetBool("Running", true);
        }
        else
        {
            _animator.SetBool("Running", false);
        }
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        _rigidbody.velocity = new Vector2(_inputData.Horizontal * _playerData.Speed, _inputData.Vertical * _playerData.Speed) * Time.fixedDeltaTime;
    }

}
