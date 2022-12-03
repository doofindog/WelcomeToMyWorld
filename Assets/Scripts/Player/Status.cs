using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    private State _state;

    public float speed;
    public float jumpForce;
    public bool canMove;
    public bool camJump;
    public bool canShoot;

    public void Init()
    {
        canMove = true;
        camJump = true;
        canShoot = true;
    }
    
    public State GetCurrentState()
    {
        return _state;
    }
}

public enum State
{
    IDLE,
    RUNNING,
    JUMPING
}
