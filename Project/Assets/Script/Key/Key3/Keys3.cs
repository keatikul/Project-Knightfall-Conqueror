using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keys3 : MonoBehaviour
{
    public Typerlevel4 typerlevel4;
    public Keys keys;
    public GameObject key3;
    public int keycount = 1;
    public BoxCollider2D collider2D;

    private void Start() {
        collider2D.enabled = false;
        key3.SetActive(false);
    }
    private void Update() {
        if(typerlevel4.complete == true)
        {
            key3.SetActive(true);
            collider2D.enabled = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player")
        {
            Destroy(key3);
            keys.UpdateKeys(keycount);
            collider2D.enabled = false;
        }
    }
}
