using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignTrigger : MonoBehaviour
{
    public bool playerStay = false;
    public GameObject PanelSign;
    
    private void Start() {
        PanelSign.SetActive(false);
    }

    private void Update() {
        if(playerStay == true)
        {
            PanelSign.SetActive(true);
        }
        if(playerStay == false)
        {
            PanelSign.SetActive(false);
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
