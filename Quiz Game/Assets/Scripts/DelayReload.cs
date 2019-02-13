using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DelayReload : MonoBehaviour {

    private float delayBeforeLoading = 5f;

    private string sceneNameToLoad = "MainMenu";

    private float timeElapsed;

	void Update () {

        timeElapsed += Time.deltaTime;
        
        if(timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
		
	}
}
