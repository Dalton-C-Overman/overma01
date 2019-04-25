using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

    public void loadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void loadBetween()
    {
        SceneManager.LoadScene("Between");
    }

    public void loadGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void loadEnd()
    {
        SceneManager.LoadScene("End");
    }

    public void quitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
