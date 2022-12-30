using System;
using UnityEngine;

namespace Manager
{


    public class Manager<T> : Singleton<T> where T : Component
    {

    }
}