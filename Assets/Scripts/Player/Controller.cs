using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Player _player;
    private Vector2 _direction;
    [SerializeField] private bool _jumpPressed;
    
    [SerializeField] private Rigidbody2D _rigidbody2D;

    public void Init(Player player)
    {
        _player = player;
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void HandleInputs()
    {
        _direction.x = Input.GetAxisRaw("Horizontal");
        _jumpPressed = Input.GetMouseButtonDown(0);
    }

    void HandleMovement()
    {
        if (_player.status.canMove)
        {
            _rigidbody2D.position += _direction * _player.status.speed * Time.deltaTime;
            transform.eulerAngles = _direction.x switch
            {
                > 0 => new Vector3(0, 0, 0),
                < 0 => new Vector3(0, 180, 0),
                _ => transform.eulerAngles
            };
        }

        if ( _jumpPressed )
        {
            _rigidbody2D.AddForce(Vector2.up * _player.status.jumpForce, ForceMode2D.Impulse);
        }
        
        _player.animController.PlayRun(_direction);
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleInputs();
    }

    private void FixedUpdate()
    {
        HandleMovement();
    }
}
