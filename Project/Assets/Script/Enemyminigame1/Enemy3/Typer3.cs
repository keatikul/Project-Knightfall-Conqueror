using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Typer3 : MonoBehaviour
{
    public Text wordOutput2 = null;

    private string remainingWord2 = string.Empty;

    private string currentWord2 = "internet of things";

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
    public bool complete3 = false;
    public GameObject CanvasTips;

    

    // Start is called before the first frame update
    void Start()
    {
        SetCurrentWord();
    }

    private void SetCurrentWord()
    {
        // Get bank word.
        SetRemainingWord(currentWord2);
    }

    private void SetRemainingWord(string newString2)
    {
        remainingWord2 = newString2;
        wordOutput2.text = remainingWord2.ToUpper();
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
        keyboard.SetActive(false);
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
                complete3 = true;
                //VictoryButton.SetActive(true);
                //SetCurrentWord();
            }
        }
    }

    private bool IsCorrectLetter(string letter)
    {
        return remainingWord2.IndexOf(letter) == 0;
    }

    private void RemoveLetter()
    {
        string newString2 = remainingWord2.Remove(0, 1);
        SetRemainingWord(newString2);
    }

    private bool IsWordComplete()
    {

        return remainingWord2.Length == 0;
    }

    public void Canvastips()
    {
        if(complete3 == true)
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
