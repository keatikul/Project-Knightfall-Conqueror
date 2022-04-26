using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Partrol : MonoBehaviour
{
    public float speed;
    public bool playerStay = false;
    public float distance;
    private bool movingRight = true;
    public Transform groundDetection;
    public Animator anim;
    void Update() {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if(groundInfo.collider == false){
            if(movingRight == true) {
                transform.eulerAngles = new Vector3(0, -180 ,0);
                movingRight = false;
                anim.SetBool("Run" , true);
            } else{
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
                anim.SetBool("Run" , true);
            }
        }
        if(playerStay == true)
        {
            transform.Translate(Vector2.right * -speed * Time.deltaTime);
            anim.SetBool("Run", false);
        }

        
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            playerStay = true;
        }
    }

}
