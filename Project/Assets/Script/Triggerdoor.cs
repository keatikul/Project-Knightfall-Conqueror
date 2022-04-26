using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerdoor : MonoBehaviour
{
    public Doorcontroll door;
    public bool playerStay = false;
    public Animator anim;
    public GameObject canvas;
    public GameObject PanelMinigame;
    public BoxCollider2D collider2D;
    void Update()
    {
        canvas.SetActive(playerStay);
        if (playerStay && Input.GetKeyDown(KeyCode.E))
         {
            door.doorOpen = !door.doorOpen;
            PanelMinigame.SetActive(true);
            canvas.SetActive(false);
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
    public void Exitcollider()
    {
        collider2D.enabled = false;
    }     
}
