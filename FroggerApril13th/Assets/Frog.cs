using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class Frog : MonoBehaviour {

    public GameObject frog;
    public GameObject continueButton;
    public GameObject endButton;

    public bool colliderOn = true;

    public static int livesUsed;
    public static int lives = 3;
    public Text livesText;

    public static float width = 1f, height = 1f;

    public Rigidbody2D rb;

    private void Start()
    {
        continueButton.SetActive(false);
        endButton.SetActive(false);
        livesText.text = lives.ToString();
    }

    void Update () {

		if (Input.GetKeyDown(KeyCode.RightArrow))
			rb.MovePosition(rb.position + Vector2.right);
		else if (Input.GetKeyDown(KeyCode.LeftArrow))
			rb.MovePosition(rb.position + Vector2.left);
		else if (Input.GetKeyDown(KeyCode.UpArrow))
			rb.MovePosition(rb.position + Vector2.up);
		else if (Input.GetKeyDown(KeyCode.DownArrow))
			rb.MovePosition(rb.position + Vector2.down);
        
    }

	void OnTriggerEnter2D (Collider2D col)
	{
        if (colliderOn == true)
        {
            if (col.tag == "Car")
            {
                Debug.Log("WE LOST!");
                Score.CurrentScore = 0;

                rb.isKinematic = false;
                lives = lives - 1;
                livesUsed = 3 - lives;
                livesText.text = lives.ToString();
                colliderOn = false;
                if (lives > 0)
                { 
                    continueButton.SetActive(true);
                    endButton.SetActive(true);
                }
                else
                {
                    endButton.SetActive(true);
                    lives = 3;
                }
            }
        }
        
	}

    void Awake()
    {
        Vector3 scale = new Vector3(width, height, 1f);
        transform.localScale = scale;
    }

    public void endClick()
    {
        SceneManager.LoadScene("End");
    }
    public void continueClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
