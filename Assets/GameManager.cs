using UnityEngine;
using UnityEngine.InputSystem;

enum GameState
{
    Playing,
    GameOver,
    Restart
}

public class GameManager : MonoBehaviour
{
    private GameState currentState;
    string guess;
    Keyboard keyboard;
    int target;
    int min = 1;
    int max = 1000;

    int attempt;
    int maxAttempt = 8;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        
        keyboard = Keyboard.current;
        StartGame();
    }

    void StartGame()
    {
        attempt = 0;
        currentState = GameState.Playing;
        target = Random.Range(min, max+1);
        Debug.Log("<size=15>Welcome to guess a number!</size>");
        Debug.Log("Think iof a number from range below");
        Debug.LogFormat("Lowest = <b>{0}</b> \n\t Highest =  <b>1000</b>", min, max);
        Debug.Log($"\n You have a maximum of {maxAttempt} attempts. enter the guess and press enter.");
    }

    // Update is called once per frame
    void Update()
    {  
        switch (currentState)
        {
            case GameState.Playing:
                HandleUserInput();   
                break;
            case GameState.GameOver:
                if(keyboard.enterKey.wasPressedThisFrame)
                {
                    currentState = GameState.Restart;
                }
                break;
            case GameState.Restart:
                StartGame();
                break;
        }
        
    }
    void HandleUserInput()
    {
        if(keyboard.digit0Key.wasPressedThisFrame)
        {
            guess += "0";
        }
        if(keyboard.digit1Key.wasPressedThisFrame)
        {
            guess += "1";
        }
        if(keyboard.digit2Key.wasPressedThisFrame)
        {
            guess += "2";
        }
        if(keyboard.digit3Key.wasPressedThisFrame)
        {
            guess += "3";
        }
        if(keyboard.digit4Key.wasPressedThisFrame)
        {
            guess += "4";
        }
        if(keyboard.digit5Key.wasPressedThisFrame)
        {
            guess += "5";
        }
        if(keyboard.digit6Key.wasPressedThisFrame)
        {
            guess += "6";
        }
        if(keyboard.digit7Key.wasPressedThisFrame)
        {
            guess += "7";
        }
        if(keyboard.digit8Key.wasPressedThisFrame)
        {
            guess += "8";
        }
        if(keyboard.digit9Key.wasPressedThisFrame)
        {
            guess += "9";
        }
        if(keyboard.enterKey.wasPressedThisFrame)
        {
            Debug.Log("The number you have guessed is " + guess);
            if(int.TryParse(guess, out int playerGuess))
            {
                if(playerGuess < min || playerGuess > max)
                {
                    Debug.Log("Invalid input");
                }
                else
                {
                    attempt++;
                    if(playerGuess == target)
                    {
                        Debug.Log("Your answer is right!!");
                        currentState = GameState.GameOver;
                    }
                    else if(attempt >= maxAttempt)
                    {
                        Debug.Log($"You have exceeded the maximum number of {maxAttempt} attempts \n the correct answer was {target}.");
                        currentState = GameState.GameOver;
                    }
                    else if(playerGuess > target)
                    {
                       Debug.Log("Guess is too high!!"); 
                    }
                    else
                    {
                        Debug.Log("Guess is too low!!"); 
                    }
                }
            }
            else
            {
                Debug.Log("Input invalid");
            }

            guess = "";
        }
    }
}
