using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    public GameObject Arrow;
    public bool playerStay = false;
    public Animator anim; 
    // Start is called before the first frame update
    void Start()
    {
        Arrow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(playerStay == true)
        {
            Arrow.SetActive(true);
            anim.SetBool("Trigger", true);
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
