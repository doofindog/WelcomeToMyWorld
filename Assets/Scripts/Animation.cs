using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    Animator anim;

    public void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Walk(Vector3 direction)
    {

        if (direction.magnitude > 0)
        {
            anim.SetBool("running", true);
        }
        else 
        {
            anim.SetBool("running", false);
        }
    }
}
