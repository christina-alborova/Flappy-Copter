using Game;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class HudView : View
    {
        [SerializeField]
        private Text scoreValueText;

        [SerializeField]
        private Text recordValueText;

        private Player _player;

        private void OnEnable()
        {
            _player = FindObjectOfType<Player>();
            _player.ScoreChanged += OnPlayerScoreChanged;
        }

        private void OnDisable()
        {
            _player.ScoreChanged -= OnPlayerScoreChanged;
        }

        private void OnPlayerScoreChanged()
        {
            scoreValueText.text = _player.Score.ToString();
            recordValueText.text = _player.Record.ToString();
        }
    }
}