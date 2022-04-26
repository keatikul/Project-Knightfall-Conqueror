using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerchest3 : MonoBehaviour
{
    public bool playerStay = false;
    public GameObject canvas;
    private Vector3 resposition;
    public GameObject Chestposition;
    public Animator anim;
    public Keys keys;
    //public Keys1 keys1;
    public LevelmanagerLevel2 manager;

    private void Start() 
    {
        resposition = transform.position;   
    }
    void Update()
    {
        
        canvas.SetActive(playerStay);
         if (playerStay && Input.GetKeyDown(KeyCode.E) && keys.havekey > 0)
         {
            keys.havekey -= 1;
            anim.SetBool("Open",true);
            manager.SetTextKeys(keys.havekey);
         }
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            playerStay = true;
            resposition = transform.position;
        }
    }
    void OnTriggerExit2D(Collider2D other) {
       if (other.gameObject.tag == "Player") {
           playerStay = false;
       }
    }
}
