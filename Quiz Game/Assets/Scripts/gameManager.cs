using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {
    private const string V = "WRONG";

    //string [,] CSVarray = LoadCSV.array;

    public Question[] questions;
    private static List<Question> unansweredQuestions;

    private Question currentQuestion;

    [SerializeField]
    private Text answerAText;
    [SerializeField]
    private Text answerBText;
    [SerializeField]
    private Text answerCText;
    [SerializeField]
    private Text answerDText;

    [SerializeField]
    private Animator animator;

    [SerializeField]
    private Text questionText;

    [SerializeField]
    private float timeBetweenQuestions = 2f;

    private void Start()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }

        SetCurrentQuestion();
/*      Debug.Log(currentQuestion.question + " is A" + currentQuestion.isA);
        Debug.Log(currentQuestion.question + " is B" + currentQuestion.isB);
        Debug.Log(currentQuestion.question + " is C" + currentQuestion.isC);
        Debug.Log(currentQuestion.question + " is D" + currentQuestion.isD);
*/
    }

    void SetCurrentQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        questionText.text = currentQuestion.q;

        if(currentQuestion.isA)
        {
            answerAText.text = "CORRECT!";
            answerBText.text = V;
            answerCText.text = V;
            answerDText.text = V;
        }
        else if(currentQuestion.isB)
        {
            answerAText.text = V;
            answerBText.text = "CORRECT!";
            answerCText.text = V;
            answerDText.text = V;
        }
        else if(currentQuestion.isC)
        {
            answerAText.text = V;
            answerBText.text = V;
            answerCText.text = "CORRECT!";
            answerDText.text = V;
        }
        else if(currentQuestion.isD)
        {
            answerAText.text = V;
            answerBText.text = V;
            answerCText.text = V;
            answerDText.text = "CORRECT!";
        }
    }

    IEnumerator transitionToNextQuestion()
    {
        unansweredQuestions.Remove(currentQuestion);

        yield return new WaitForSeconds(timeBetweenQuestions);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void userSelectA()
    {
        animator.SetTrigger("ClickA");
        if(currentQuestion.isA)
        {
            Debug.Log("Correct!");
        }
        else
        {
            Debug.Log("Wrong!");
        }

        StartCoroutine(transitionToNextQuestion());
    }

    public void userSelectB()
    {
        animator.SetTrigger("ClickB");
        if (currentQuestion.isB)
        {
            Debug.Log("Correct!");
        }
        else
        {
            Debug.Log("Wrong!");
        }

        StartCoroutine(transitionToNextQuestion());

    }

    public void userSelectC()
    {
        animator.SetTrigger("ClickC");
        if (currentQuestion.isC)
        {
            Debug.Log("Correct!");
        }
        else
        {
            Debug.Log("Wrong!");
        }

        StartCoroutine(transitionToNextQuestion());

    }

    public void userSelectD()
    {
        animator.SetTrigger("ClickD");
        if (currentQuestion.isD)
        {
            Debug.Log("Correct!");
        }
        else
        {
            Debug.Log("Wrong!");
        }

        StartCoroutine(transitionToNextQuestion());

    }
}
