using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    // Название сцены, переносит на неё при нажатии кнопки
    public string startGameScene { get; set; }

    public void StartGame()
    {
        SceneManager.LoadScene(startGameScene);
    }
}
