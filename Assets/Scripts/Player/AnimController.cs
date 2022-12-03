using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    public void Init()
    {
        _animator = GetComponent<Animator>();
    }

    public void PlayRun(Vector2 direction)
    {
        _animator.SetInteger("direction", (int)direction.x);
    }

    public void PlayJump(bool isFalling)
    {
        _animator.SetBool("falling", isFalling);
    }
}
