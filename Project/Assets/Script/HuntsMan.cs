using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuntsMan : MonoBehaviour
{
    public bool playerStay = false;
    public GameObject textHM;
    public GameObject Balloon;
    // Start is called before the first frame update
    void Start()
    {
        Balloon.SetActive(false);
        textHM.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(playerStay == true)
        {
            Balloon.SetActive(true);
            textHM.SetActive(true);
        }
        if(playerStay == false)
        {
            textHM.SetActive(false);
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
