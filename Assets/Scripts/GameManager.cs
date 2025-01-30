using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI opponentScoreText;
    private int playerScore = 0;
    private int opponentScore = 0;

    public void PlayerScores()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
        ball.ResetPosition();
    }

    public void OpponentScores()
    {
        opponentScore++;
        opponentScoreText.text = opponentScore.ToString();
        ball.ResetPosition();
    }
}
