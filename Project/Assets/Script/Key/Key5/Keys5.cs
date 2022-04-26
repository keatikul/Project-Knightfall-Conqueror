using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keys5 : MonoBehaviour
{
  
    public Typerlevel6 typerlevel6;
    public Keys keys;
    public GameObject key5;
    public int keycount = 1;
    public BoxCollider2D collider2D;

    private void Start() {
        collider2D.enabled = false;
        key5.SetActive(false);
    }
    private void Update() {
        if(typerlevel6.complete == true)
        {
            key5.SetActive(true);
            collider2D.enabled = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player")
        {
            Destroy(key5);
            keys.UpdateKeys(keycount);
            collider2D.enabled = false;
        }
    }
}
