using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {


        Debug.Log("Welcome to number wizard, Borko!");
        Debug.Log("you supposed a pick a number ");
        Debug.Log("Highest possible number is: " + max);
        Debug.Log("lowest possible number it: " + min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
            min = guess;
            guess = (max + min) / 2;
            Debug.Log(guess);

        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed.");
            max = guess;
            guess = (max - min) / 2;
            Debug.Log(guess);
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You hit enter.");
        }
    }
}
