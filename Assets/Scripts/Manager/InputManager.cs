using UnityEngine;

namespace Manager
{
    public class InputManager : Manager<InputManager>
    {
        public Vector2 DirectionAxis
        {
            get
            {
                return ReadAxis();
            }
        }

        public void Awake()
        {
        
        }

        private Vector3 ReadAxis()
        {
            Vector3 position = new Vector3()
            {
                x = Input.GetAxis("Horizontal"),
                y = Input.GetAxis("Vertical")
            };

            return position;
        }
    }
}

