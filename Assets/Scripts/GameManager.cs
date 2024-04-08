using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] Ball ball;
    [SerializeField] Paddle playerPaddle, computerPaddle;
    [SerializeField] TextMeshProUGUI computerScoreText;
    [SerializeField] TextMeshProUGUI playerScoreText;
    int _playerScore = 0;
    int _computerScore = 0;

    public void PlayerScores() {
        _playerScore++;
        playerScoreText.text = _computerScore.ToString();
        ResetRound();
    }
    public void ComputerScores() {
        _computerScore++;
        computerScoreText.text = _computerScore.ToString();
        ResetRound();
    }

    void ResetRound() {
        ball.ResetPosition();
        ball.AddStartingForce();
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
    }
}

