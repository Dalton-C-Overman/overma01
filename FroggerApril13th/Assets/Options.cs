using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour {

    public Dropdown carSpeed;
    public Dropdown spawnSpeed;
    public Dropdown carSize;
    public Dropdown frogSize;

    // Update is called once per frame
    void Update () {

        switch(carSpeed.value)
        {
            case 1:
                Car.minSpeed = 4f;
                Car.maxSpeed = 6f;
                break;
            case 2:
                Car.minSpeed = 8f;
                Car.maxSpeed = 12f;
                break;
            case 3:
                Car.minSpeed = 14f;
                Car.maxSpeed = 16f;
                break;
        }

        switch(spawnSpeed.value)
        {
            case 1:
                CarSpawner.spawnDelay = .75f;
                break;
            case 2:
                CarSpawner.spawnDelay = .3f;
                break;
            case 3:
                CarSpawner.spawnDelay = .1f;
                break;
        }

        switch(carSize.value)
        {
            case 1:
                Car.width = .5f;
                Car.height = .5f;
                break;
            case 2:
                Car.width = 1f;
                Car.height = 1f;
                break;
            case 3:
                Car.width = 1.5f;
                Car.height = 1.5f;
                break;
        }

        switch(frogSize.value)
        {
            case 1:
                Frog.width = .5f;
                Frog.height = .5f;
                break;
            case 2:
                Frog.width = 1f;
                Frog.height = 1f;
                break;
            case 3:
                Frog.width = 1.25f;
                Frog.height = 1.25f;
                break;

        }
		
	}

    public void play()
    {
        SceneManager.LoadScene("Main");
    }
}
