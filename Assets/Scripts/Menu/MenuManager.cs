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

    // Индекс сцены, переносит на неё при нажатии кнопки
    public int startGameScene;

    public void StartGame()
    {
        SceneManager.LoadScene(startGameScene);
    }
}
