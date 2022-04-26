using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typer2 : MonoBehaviour
{
    public Text wordOutput1 = null;

    private string remainingWord1 = string.Empty;

     private string currentWord1 = "identity check";

    //LevelManagerTest fd;

    public float timeValue = 10;
    public Text timeText;
    //public LevelManagerTest manager;
    public int playerHeart = 5;
    public GameObject CloseButton;
    public GameObject VictoryButton;
    public GameObject panelMinigame;
    public GameObject Enemy;
    public GameObject keyboard;
    public bool complete2 = false;
    public GameObject CanvasTips;

    

    // Start is called before the first frame update
    void Start()
    {
        SetCurrentWord();
    }

    private void SetCurrentWord()
    {
        // Get bank word.
        SetRemainingWord(currentWord1);
    }

    private void SetRemainingWord(string newString1)
    {
        remainingWord1 = newString1;
        wordOutput1.text = remainingWord1.ToUpper();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
        Canvastips();
        ExitBton();
        /*if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
             
        }
        DisplayTime(timeValue);
        if(timeValue == 0)
        {   
            //Timesup();
            Debug.Log("Time's Up");
        }*/
        
    }
    void Timesup() 
    {
        CloseButton.SetActive (true);
    }

    public void ExitButton()
    {      
        panelMinigame.SetActive(false);
        keyboard.SetActive(false);
        //manager.SetTextHeart(playerHeart);
    }

    public void Victory()
    {
        //panelMinigame.SetActive(false);
        Destroy(Enemy);
    }
    /*void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        float minutes =  Mathf.FloorToInt(timeToDisplay / 60);
        float secounds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text =  string.Format("{0:00}:{1:00}", minutes , secounds);
    }*/
    

    private void CheckInput()
    {
        if(Input.anyKeyDown)
        {
            string keysPressed = Input.inputString;

            if(keysPressed.Length == 1)
            {
                EnterLetter(keysPressed);
            }
                
        }
    }

    private void EnterLetter(string typedLetter)
    {
        if(IsCorrectLetter(typedLetter))
        {
            RemoveLetter();
            if(IsWordComplete())
            {
                panelMinigame.SetActive(false);
                Destroy(Enemy);
                keyboard.SetActive(false);
                complete2 = true;
                //VictoryButton.SetActive(true);
                //SetCurrentWord();
            }
        }
    }

    private bool IsCorrectLetter(string letter)
    {
        return remainingWord1.IndexOf(letter) == 0;
    }

    private void RemoveLetter()
    {
        string newString1 = remainingWord1.Remove(0, 1);
        SetRemainingWord(newString1);
    }

    private bool IsWordComplete()
    {

        return remainingWord1.Length == 0;
    }

    public void Canvastips()
    {
        if(complete2 == true)
        {
            CanvasTips.SetActive(true);
        }
    }

    public void ExitBton()
    {
        timeValue -= Time.deltaTime;
        if(timeValue <= 0)
        {
            CanvasTips.SetActive(false);
        }
    }

}
