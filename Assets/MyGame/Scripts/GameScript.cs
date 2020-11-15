using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    int max;
    int min;
    int guess;
    public Text textGuess;

    // Start is called before the first frame update
    void Start()
    {
        max = 100;
        min = 1;
        guess = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guessNext();
            Debug.Log("Higher");
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guessNext();
            Debug.Log("Lower");
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("correct Guess");
            SceneManager.LoadScene("FinishedScene", LoadSceneMode.Single);
        }

    }

    void guessNext()
    {
        guess = (min + max) / 2;
        textGuess.text = guess.ToString();
    }
}
