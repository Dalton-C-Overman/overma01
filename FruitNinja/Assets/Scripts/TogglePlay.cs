using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TogglePlay : MonoBehaviour {

    public Toggle haveRead;

    private void Start()
    {
        haveRead = GetComponent<Toggle>();
    }

    public void playMethod()
    {
        if (haveRead.isOn)
            SceneManager.LoadScene("Between");
    }

}
