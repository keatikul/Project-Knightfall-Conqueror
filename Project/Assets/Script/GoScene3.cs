using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoScene3 : MonoBehaviour
{
    public bool playerStay = false;

    void Update()
    {
        if(playerStay == true)
        {
            SceneManager.LoadScene("Story6");
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
