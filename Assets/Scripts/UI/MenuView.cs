using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace UI
{
    public class MenuView : View
    {
        private const string GameSceneName = "Game";

        [SerializeField]
        private Button playButton;

        [SerializeField]
        private Button optionsButton;

        [SerializeField]
        private Button exitButton;

        private void OnEnable()
        {
            playButton.onClick.AddListener(OnPlayButtonClicked);
            optionsButton.onClick.AddListener(OnOptionsButtonClicked);
            exitButton.onClick.AddListener(OnExitButtonClicked);
        }

        private void OnDisable()
        {
            playButton.onClick.RemoveListener(OnPlayButtonClicked);
            optionsButton.onClick.RemoveListener(OnOptionsButtonClicked);
            exitButton.onClick.RemoveListener(OnExitButtonClicked);
        }

        private void OnPlayButtonClicked()
        {
            SceneManager.LoadSceneAsync(GameSceneName, LoadSceneMode.Additive);
        }

        private void OnOptionsButtonClicked() { }

        private void OnExitButtonClicked()
        {
            Application.Quit();
        }
    }
}