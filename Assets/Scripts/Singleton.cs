using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Component
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            _instance = FindObjectOfType<T>();
            if (_instance == null)
            {
                GameObject obj = new GameObject();
                obj.name =  $"{typeof(T).Name} (Singleton)";
                _instance = obj.AddComponent<T>();
            }
        
            return _instance;
        }
    }
}
