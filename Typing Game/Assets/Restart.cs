using UnityEngine.SceneManagement;
using UnityEngine;

public class Restart : MonoBehaviour
{


    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
