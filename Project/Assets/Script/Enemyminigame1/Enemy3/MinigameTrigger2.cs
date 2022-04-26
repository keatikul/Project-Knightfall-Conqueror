using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinigameTrigger2 : MonoBehaviour
{
    public GameObject panelMinigame;
    public GameObject buttonReady;
    public bool playerStay = false;
    public float timeValue = 10;
    public Text timeText;
    public bool timesready = false;
    public GameObject CloseButton;
    public GameObject Enemy;
    public GameObject typer;
    public GameObject keyboard;


    // Update is called once per frame
    private void Start() {
        typer.SetActive(false);
        keyboard.SetActive(false);
    }
    void Update()
    {
        if(playerStay == true)
        {
            buttonReady.SetActive(true);
        }
        if(timesready == true)
        {
            timer();
        }
    }

    public void ButtonReady()
    {
        timesready = true;
        Destroy(buttonReady);
        playerStay = false;
        typer.SetActive(true);
        panelMinigame.SetActive(true);
        keyboard.SetActive(true);
    }
    void timer()
    {
        if (timeValue > 0)
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
            Timesup();
            keyboard.SetActive(false);
            Debug.Log("Time's Up");
        }   
    }
    void Timesup() 
    {
        Destroy(Enemy);
        CloseButton.SetActive (true);
        typer.SetActive(false);
    }

    public void ExitButton()
    {      
        panelMinigame.SetActive(false);
        keyboard.SetActive(false);
        //manager.SetTextHeart(playerHeart);
    }
    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }
        float minutes =  Mathf.FloorToInt(timeToDisplay / 60);
        float secounds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text =  string.Format("{0:00}:{1:00}", minutes , secounds);
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            playerStay = true;
        }
    }
    void OnTriggerExit2D(Collider2D other) {
       if (other.gameObject.tag == "Player") {
           playerStay = false;
           buttonReady.SetActive(false);
       }
    }
}
