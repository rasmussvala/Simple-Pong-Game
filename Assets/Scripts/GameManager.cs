using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI opponentScoreText;
    public GameObject pauseMenu;
    private bool _isPaused;
    private int _opponentScore;
    private int _playerScore;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) TogglePause();
    }

    public void PlayerScores()
    {
        _playerScore++;
        playerScoreText.text = _playerScore.ToString();
        ball.ResetPosition();
    }

    public void OpponentScores()
    {
        _opponentScore++;
        opponentScoreText.text = _opponentScore.ToString();
        ball.ResetPosition();
    }

    private void TogglePause()
    {
        _isPaused = !_isPaused;
        Time.timeScale = _isPaused ? 0 : 1;
        pauseMenu.SetActive(_isPaused);
    }
}