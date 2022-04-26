using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prank : MonoBehaviour
{
    public GameObject plate;
    public bool playerStay = false;
    
    private void Start() {
        plate.SetActive(true);
    }
    void Update()
    {
        if(playerStay == true)
        {
            plate.SetActive(false);
        }
        if(playerStay == false)
        {
            plate.SetActive(true);
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
