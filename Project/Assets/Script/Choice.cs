using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choice : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Choice01;
    public GameObject Choice02;
    public GameObject Choice03;
    public GameObject Choice04;

    public GameObject CloseButton;
    public GameObject panelMinigame;
    public int ChoiceMade;
    public int playerHeart = 5;
    public LevelManagerTest manager;

    

    public void ChoiceOption1() 
    {
        TextBox.GetComponent<Text>().text = "This is galaxy caught it on my bd!!";
        ChoiceMade = 1;
    }
    public void ChoiceOption2() 
    {
        TextBox.GetComponent<Text>().text = "You pick the wrong choice fools";
        ChoiceMade = 2;
        playerHeart -= 1;
        manager.SetTextHeart(playerHeart);
    }
    public void ChoiceOption3() 
    {
        TextBox.GetComponent<Text>().text = "Why you so dumb";
        ChoiceMade = 3;
        playerHeart -= 1;
        manager.SetTextHeart(playerHeart);
    }
    public void ChoiceOption4() 
    {
        TextBox.GetComponent<Text>().text = "Ayy sresly No!!";
        ChoiceMade = 4;
        playerHeart -= 1;
        manager.SetTextHeart(playerHeart);
    }
    public void ExitButton()
    {
        panelMinigame.SetActive(false);   
    }


    // Update is called once per frame
    void Update()
    {
        if (ChoiceMade >= 1) 
        {
            Choice01.SetActive (false);
            Choice02.SetActive (false);
            Choice03.SetActive (false);
            Choice04.SetActive (false);
            CloseButton.SetActive (true);
        }
        
    }
}
