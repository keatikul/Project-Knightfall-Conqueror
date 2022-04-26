using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TyperBoss : MonoBehaviour
{
    public Text wordOutput = null;
    public Wordbank wordbank = null;

    private string remainingWord = string.Empty;

    private string currentWord = string.Empty;
    //public Animator anim;
    //LevelManagerTest fd;
    //public float timeValue = 5;
    //public Text timeText;
    //public LevelManagerTest manager;
    //public int playerHeart = 5;
    public GameObject CloseButton;
    public GameObject VictoryButton;
    public GameObject panelMinigame;
    public GameObject Enemy;
    public GameObject keyboard;
    public bool complete = false;
    public GameObject ChoiceGame;
    public BoxCollider2D collider2D;

    

    // Start is called before the first frame update
    void Start()
    {
        SetCurrentWord();
    }

    private void SetCurrentWord()
    {
        currentWord = wordbank.GetWord();
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
        if(wordbank.completer == true)
        {
            panelMinigame.SetActive(false);
            Destroy(Enemy);
            keyboard.SetActive(false);
            ChoiceGame.SetActive(true);
        }
    }
    void Timesup() 
    {
        CloseButton.SetActive (true);
    }

    public void ExitButton()
    {      
        panelMinigame.SetActive(false);
    }

    public void Victory()
    {
        Destroy(Enemy);
    }
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
                //panelMinigame.SetActive(false);
                //Destroy(Enemy);
                //keyboard.SetActive(false);
                complete = true;
                //VictoryButton.SetActive(true);
                SetCurrentWord();
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

    public bool IsWordComplete()
    {

        return remainingWord.Length == 0;
    }

    public void Exitcollider()
    {
        ChoiceGame.SetActive(false);
        collider2D.enabled = false;
        wordbank.completer = false;
    }     
}
