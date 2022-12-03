using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Status), typeof(Controller))]
public class Player : MonoBehaviour
{
    public Status status;
    public AnimController animController;
    public Controller controller;

    private void Start()
    {
        status = GetComponent<Status>();
        animController = GetComponent<AnimController>();
        controller = GetComponent<Controller>();
        
        status.Init();
        animController.Init();
        controller.Init(this);
    }
}
