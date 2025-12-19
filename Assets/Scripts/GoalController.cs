using System;
using UnityEngine;

namespace Pong.Controllers
{
    public class GoalController : MonoBehaviour
    {
        [SerializeField] private bool isGoalOnPlayer1sSide;
        [SerializeField] private BallController ballController;
        [SerializeField] private GameManager gameManager;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (!collision.gameObject.CompareTag("Ball"))
            {
                return;
            }

            // PLAYER 1 SCORED
            // If isGoalOnPlayer1Side is false, this means that this is the goal on Player1's side.
            if (!isGoalOnPlayer1sSide)
            {
                gameManager.Player1Scored();
            }
            else
            {
                gameManager.Player2Scored();
            }

            ballController.LaunchBall();
        }
    }
}
