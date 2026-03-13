using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{

    string guess = "21";
    int min = 1;
    int max = 1000;
    Keyboard keyboard;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        keyboard = Keyboard.current;
        Debug.Log("<size=15>Welcome to guess a number!</size>");
        Debug.Log("Think iof a number from range below");
        Debug.LogFormat("Lowest = <b>{0}</b> \n\t Highest =  <b>1000</b>", min, max);
        Debug.Log("\n enter the number from number pad and press enter.");
        Debug.Log("our Guess is "+ guess);
        
    }

    // Update is called once per frame
    void Update()
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
            Debug.Log("The number you have guessed is "+ guess);
            guess = "";
        }
        
    }
}
