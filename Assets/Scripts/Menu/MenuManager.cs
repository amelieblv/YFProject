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

    // Номер сцены, когда нажата кнопка начала
    public int startGameScene;

    public void StartGame()
    {
        SceneManager.LoadScene(startGameScene);
    }
}
