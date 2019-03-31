using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour {

    public Text highScore1;

    public AudioMixer audioMixer;

    public void SetVolume (float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
    
    public void resetScore()
    {
        PlayerPrefs.DeleteKey("HighScore1");
    }

    public void loadCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void loadInfoPage()
    {
        SceneManager.LoadScene("InfoScreen");
    }
   
    public void loadOptions()
    {
        SceneManager.LoadScene("Options");
    }

    public void quitGame ()
    {
        Application.Quit();
    }

    public void loadGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void loadHigh()
    {
        SceneManager.LoadScene("HighScores");
    }

    public void gameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void highScore()
    {
        highScore1.text = PlayerPrefs.GetInt("HighScore1", 0).ToString();
    }
}
