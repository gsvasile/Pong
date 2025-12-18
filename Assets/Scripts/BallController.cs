using UnityEngine;

namespace Pong
{
    public class BallController : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D myRigidBody;
        [SerializeField] private float speed;

        private void Awake()
        {
            AutoSetRigidBody();
        }

        private void AutoSetRigidBody()
        {
            if (myRigidBody != null)
            {
                return;
            }

            var rigidBoy = GetComponent<Rigidbody2D>();
            if (rigidBoy != null)
            {
                myRigidBody = rigidBoy;
            }
        }

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private void Start()
        {
            LaunchBall();
        }

        public void LaunchBall()
        {
            transform.position = Vector2.zero;
            
            float x = 0;
            float y = 0;

            var randomNumber = Random.Range(0, 4);

            switch (randomNumber)
            {
                case 0:
                {
                    x = 1;
                    y = 1;
                    break;
                }
                case 1:
                {
                    x = 1;
                    y = -1;
                    break;
                }
                case 2:
                {
                    x = -1;
                    y = 1;
                    break;
                }
                case 3:
                {
                    x = -1;
                    y = -1;
                    break;
                }
            }

            myRigidBody.linearVelocity = new Vector2(x, y) * speed;
        }
    }
}
