using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

	public void loadMain()
    {
        SceneManager.LoadScene("Main");
    }

    public void quitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void loadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void End()
    {
        SceneManager.LoadScene("End");
    }
}
