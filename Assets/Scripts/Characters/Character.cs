using Manager;
using UnityEngine;

namespace Characters
{
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
}
