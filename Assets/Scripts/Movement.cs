﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public void Move(Vector3 direction, float speed)
    {
        transform.position += direction * speed * Time.deltaTime;

        if (direction.x > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (direction.x < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }
}
