using System;
using TMPro;
using UnityEngine;

namespace Pong
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI player1ScoreText;
        [SerializeField] private TextMeshProUGUI player2ScoreText;

        private int _player1Score = 0;
        private int _player2Score = 0;

        private void Start()
        {
            player1ScoreText.text = _player1Score.ToString();
            player2ScoreText.text = _player2Score.ToString();
        }

        public void Player1Scored()
        {
            _player1Score++;
            player1ScoreText.text = _player1Score.ToString();
        }

        public void Player2Scored()
        {
            _player2Score++;
            player2ScoreText.text = _player2Score.ToString();
        }
    }
}
