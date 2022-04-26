using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrincessTrigger : MonoBehaviour
{
    public Animator anim;
    public GameObject Balloon;
    public bool playerStay = false;
    // Start is called before the first frame update
    void Start()
    {
        Balloon.SetActive(false);
        anim.SetBool("Flip", false);
    }

    // Update is called once per frame
    void Update()
    {
        if(playerStay == true)
        {
            Balloon.SetActive(true);
            anim.SetBool("Flip", true);
            SceneManager.LoadScene("Story7");
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
