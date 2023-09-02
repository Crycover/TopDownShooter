using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private InputData _inputData;
    [SerializeField] private PlayerData _playerData;

    private Rigidbody2D _rigidbody;
    private Animator _animator;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        Movement();
    }

    private void Movement()
    {
        _rigidbody.velocity = new Vector2(_inputData.Horizontal * _playerData.Speed, _inputData.Vertical * _playerData.Speed) * Time.fixedDeltaTime;
    }

    void Update()
    {
        InputManager();
    }

    private void InputManager()
    {
        _inputData.Horizontal = Input.GetAxis("Horizontal");
        _inputData.Vertical = Input.GetAxis("Vertical");
    }


}
