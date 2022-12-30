using System;
using UnityEngine;

namespace Manager
{


    public class Manager<T> : Singleton<T> where T : Component
    {
        private static Transform managerParent;

        public void Awake()
        {
            if (managerParent == null)
            {
                managerParent = GameObject.Find("Managers").transform;
                if (managerParent == null)
                {
                    managerParent = new GameObject().transform;
                    managerParent.name = "Manager";
                }
            }

            transform.SetParent(managerParent);
        }
    }
}