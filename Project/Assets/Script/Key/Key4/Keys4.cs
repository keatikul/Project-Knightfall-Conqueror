using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keys4 : MonoBehaviour
{
    public Typerlevel5 typerlevel5;
    public Keys keys;
    public GameObject key4;
    public int keycount = 1;
    public BoxCollider2D collider2D;

    private void Start() {
        collider2D.enabled = false;
        key4.SetActive(false);
    }
    private void Update() {
        if(typerlevel5.complete == true)
        {
            key4.SetActive(true);
            collider2D.enabled = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player")
        {
            Destroy(key4);
            keys.UpdateKeys(keycount);
            collider2D.enabled = false;
        }
    }
}
