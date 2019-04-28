using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsMain : MonoBehaviour {

    //public Toggle haveRead;
    //public Button playButton;
    //public bool playBool = false;

    public Dropdown fruitSize;
    public Dropdown spawnSpeed;
    public Dropdown fruitSpeed;
    public Dropdown fruitChoice;
    public Dropdown bladeSize;
    public Dropdown gravity;
    public Dropdown gameMode;

    public GameObject orange;
    public GameObject melon;
    /*
    private void Awake()
    {
        orange = gameObject.GetComponent<FruitSpawner>().orangePrefab;
        melon = gameObject.GetComponent<FruitSpawner>().melonPrefab;
    }
    */
   /* private void Start()
    {
        haveRead = GetComponent<Toggle>();
    }

    public void playMethod()
    {
        if (haveRead.isOn)
            SceneManager.LoadScene("Main");
    }
    */
    void Update ()
    {


		
        switch(fruitSize.value)
        {
            case 1://small
                FruitSpawner.size = .5f;
                break;
            case 2://regular
                FruitSpawner.size = .8f;
                break;
            case 3://large
                FruitSpawner.size = 1.2f;
                break;
        }
        

        switch (spawnSpeed.value)
        {
            case 1://slow
                FruitSpawner.minDelay = .5f;
                FruitSpawner.maxDelay = 1.5f;
                break;
            case 2://regular
                FruitSpawner.minDelay = .1f;
                FruitSpawner.maxDelay = 1f;
                break;
            case 3://fast
                FruitSpawner.minDelay = .05f;
                FruitSpawner.maxDelay = .5f;
                break;
        }

        switch (fruitSpeed.value)
        {
            case 1://slow
                Fruit.startForce = 12f;
                break;
            case 2://regular
                Fruit.startForce = 15f;
                break;
            case 3://fast
                Fruit.startForce = 18f;
                break;
        }

        switch (fruitChoice.value)
        {
            case 1://melon
                FruitSpawner.fruitPrefab = melon;
                break;
            case 2://orange
                FruitSpawner.fruitPrefab = orange;
                break;
        }

        switch (bladeSize.value)
        {
            case 1://low
                Blade.bladeSize = .075f;
                break;
            case 2://regular
                Blade.bladeSize = .15f;
                break;
            case 3://high
                Blade.bladeSize = .30f;
                break;
        }

        switch (gravity.value)
        {
            case 1://low
                Fruit.rb.gravityScale = .5f;
                break;
            case 2://regular
                Fruit.rb.gravityScale = 1;
                break;
            case 3://high
                Fruit.rb.gravityScale = 1.5f;
                break;
        }

    }
}
