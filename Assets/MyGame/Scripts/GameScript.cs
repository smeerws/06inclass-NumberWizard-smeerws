using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    int max;
    int min;
    int guess;

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
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guessNext();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("correct Guess");
        }
    }

    void guessNext()
    {
        guess = (min + max) / 2;
    }
}
