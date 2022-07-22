using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() {
        GameObject.Find("Game").SetActive(true);
    }
    public void StopGame() {
        Application.Quit();
    }

}
