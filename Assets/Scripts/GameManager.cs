using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI opponentScoreText;
    public GameObject pauseMenu;
    private int playerScore = 0;
    private int opponentScore = 0;
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

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

    void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1;
        pauseMenu.SetActive(isPaused);
    }
}
