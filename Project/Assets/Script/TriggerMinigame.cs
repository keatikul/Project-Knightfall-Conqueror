using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMinigame : MonoBehaviour
{
    public bool playerStay = false;
    public GameObject canvas;

    void Update()
    {
        canvas.SetActive(playerStay);
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
