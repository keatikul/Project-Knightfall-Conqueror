using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keys2 : MonoBehaviour
{
    public Typerlevel3 typerlevel3;
    public Keys keys;
    public GameObject key2;
    public int keycount = 1;
    public BoxCollider2D collider2D;

    private void Start() {
        collider2D.enabled = false;
        key2.SetActive(false);
    }
    private void Update() {
        if(typerlevel3.complete == true)
        {
            key2.SetActive(true);
            collider2D.enabled = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player")
        {
            Destroy(key2);
            keys.UpdateKeys(keycount);
            collider2D.enabled = false;
        }
    }
    
}
