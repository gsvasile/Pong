using UnityEngine;

namespace Pong
{
    public class GameManager : MonoBehaviour
    {
        private int _player1Score = 0;
        private int _player2Score = 0;

        public void Player1Scored()
        {
            _player1Score++;
        }

        public void Player2Scored()
        {
            _player2Score++;
        }
    }
}
