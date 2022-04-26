using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typer1 : MonoBehaviour
{
    public Text wordOutput = null;

    private string remainingWord = string.Empty;

    private string currentWord = "firewall";

    //LevelManagerTest fd;

    public float timeValue = 10;
    //public Text timeText;
    //public LevelManagerTest manager;
    //public int playerHeart = 5;
    public GameObject CloseButton;
    public GameObject VictoryButton;
    public GameObject panelMinigame;
    public GameObject Enemy;
    public GameObject keyboard;
    public bool complete1 = false;
    public GameObject CanvasTips;
    

    // Start is called before the first frame update
    void Start()
    {
        SetCurrentWord();
    }

    private void SetCurrentWord()
    {
        // Get bank word.
        SetRemainingWord(currentWord);
    }

    private void SetRemainingWord(string newString)
    {
        remainingWord = newString;
        wordOutput.text = remainingWord.ToUpper();
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
                complete1 = true;
                //VictoryButton.SetActive(true);
                //SetCurrentWord();
            }
        }
    }

    private bool IsCorrectLetter(string letter)
    {
        return remainingWord.IndexOf(letter) == 0;
    }

    private void RemoveLetter()
    {
        string newString = remainingWord.Remove(0, 1);
        SetRemainingWord(newString);
    }

    private bool IsWordComplete()
    {

        return remainingWord.Length == 0;
    }

    public void Canvastips()
    {
        if(complete1 == true)
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
