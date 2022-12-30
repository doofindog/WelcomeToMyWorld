using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera _virtualCamera;
    [SerializeField] private GameObject _target;


    private void Awake()
    {
        _virtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    private void Start()
    {
        StartFollowing();
    }


    private void SetTarget(GameObject target)
    {
        _target = target;
    }

    private void StartFollowing()
    {
        _virtualCamera.Follow = _target.transform;
        _virtualCamera.enabled = true;
    }

    private void StopFollowing()
    {
        
    }
}
