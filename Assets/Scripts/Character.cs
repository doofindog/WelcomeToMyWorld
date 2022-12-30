using System;
using System.Collections;
using System.Collections.Generic;
using Manager;
using UnityEngine;

public class Character : MonoBehaviour
{
    protected InputManager _inputManager;

    public void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        _inputManager = InputManager.Instance;
    }
}
