using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _myRigidBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Keyboard.current.wKey.IsPressed())
        {
            Debug.Log("Button W was pressed");
            _myRigidBody.linearVelocity = Vector2.up;
        }

        if (Keyboard.current.sKey.IsPressed())
        {
            Debug.Log("Button S was pressed");

            _myRigidBody.linearVelocity = Vector2.down;
        }
    }
}
