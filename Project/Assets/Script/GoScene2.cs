using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoScene2 : MonoBehaviour
{
    public bool playerStay = false;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public bool enemycount1 = false;
    public bool enemycount2 = false;
    public bool enemycount3 = false;
    public bool enemycount4 = false;
    public bool enemycount5 = false;
    public Text uiText;

    private void Start() {
        uiText.text = "Not Pass";
    }


    void Update()
    {
        if(enemy1 == null)
        {
            enemycount1 = true;
        }

        if(enemy2 == null)
        {
            enemycount2 = true;
        }

        if(enemy3 == null)
        {
            enemycount3 = true;
        }

        if(enemy4 == null)
        {
            enemycount4 = true;
        }

        if(enemy5 == null)
        {
            enemycount5 = true;
        }
        if(enemycount1 == true && enemycount2 == true && enemycount3 == true && enemycount4 == true && enemycount5 == true)
        {
            uiText.text = "Pass";
        }
        if(playerStay && enemycount1 == true && enemycount2 == true && enemycount3 == true && enemycount4 == true && enemycount5 == true)
        {
            SceneManager.LoadScene("Story5");
        }
        
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            playerStay = true;
        }
    }
    void OnTriggerExit2D(Collider2D other) {
       if (other.gameObject.tag == "Player") {
           playerStay = false;
           
       }
    }
}
