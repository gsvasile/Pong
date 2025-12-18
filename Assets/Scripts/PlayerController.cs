using UnityEngine;
using UnityEngine.InputSystem;

namespace Pong
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Movement")] 
        [SerializeField] private Rigidbody2D myRigidBody;
        [SerializeField] private float speed = 2f;

        [Header("Player Input")] 
        [SerializeField] private Key upKey = Key.W;
        [SerializeField] private Key downKey = Key.S;

        // Stores direction that the player will move
        private float _direction;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private void Start()
        {
        }

        // Update is called once per frame
        private void Update()
        {
            PlayerInput();

            myRigidBody.linearVelocity = new Vector2(0, _direction) * speed;
        }

        private void PlayerInput()
        {
            var kb = Keyboard.current;
            if (kb == null)
            {
                return;
            }

            if (upKey != Key.None && kb[upKey].IsPressed())
            {
                _direction = 1f;
            }
            else if (downKey != Key.None && kb[downKey].IsPressed())
            {
                _direction = -1f;
            }
            else
            {
                _direction = 0f;
            }
        }
    }
}
