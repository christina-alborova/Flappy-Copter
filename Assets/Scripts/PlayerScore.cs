using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;

    [SerializeField]
    private Text highScoreText;

    private int _addScore;
    private int _highScore;

    private void Start()
    {
        _addScore = 0;
        _highScore = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Block")) return;

        _addScore++;

        if (_addScore > _highScore) _highScore = _addScore;

        scoreText.text = _addScore.ToString();
        highScoreText.text = _highScore.ToString();
    }
}