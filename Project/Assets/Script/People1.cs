using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People1 : MonoBehaviour
{
   public Animator anim;
    public GameObject Balloon;
    public bool playerStay = false;
    public GameObject textpeople;
    // Start is called before the first frame update
    void Start()
    {
        Balloon.SetActive(false);
        anim.SetBool("Donothing", true);
        textpeople.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(playerStay == true)
        {
            Balloon.SetActive(true);
            anim.SetBool("Donothing", true);
            textpeople.SetActive(true);
        }
        if(playerStay == false)
        {
            textpeople.SetActive(false);
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
