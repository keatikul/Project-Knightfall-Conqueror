using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireglitch : MonoBehaviour
{
    public GameObject Fire;
    public bool playerStay = false;
    public Animator anim; 
    // Start is called before the first frame update
    void Start()
    {
        Fire.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(playerStay == true)
        {
            Fire.SetActive(true);
            anim.SetBool("Fire", true);
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
