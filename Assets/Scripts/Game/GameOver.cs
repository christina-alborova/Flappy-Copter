using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game
{
    [RequireComponent(typeof(Collider2D))]
    public class GameOver : MonoBehaviour
    {
        private const string GameSceneName = "Game";
        private const string MenuSceneName = "Main";
        
        private void OnTriggerEnter2D(Collider2D collision)
        {
            SceneManager.UnloadSceneAsync(GameSceneName);
            SceneManager.LoadSceneAsync(MenuSceneName);
        }
    }
}