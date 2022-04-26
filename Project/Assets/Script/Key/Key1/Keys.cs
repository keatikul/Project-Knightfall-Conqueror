using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keys : MonoBehaviour
{
    public Typerlevel2 typer2;
    public bool key;
    public int havekey = 0;
    public int gotkey1 = 1;
    public GameObject key1;
    public GameObject keystext;
    public LevelmanagerLevel2 manager;
    public BoxCollider2D collider2D;
    public Keys2 keys2;
    public Keys3 keys3;
    public Keys4 keys4;
    public Keys5 keys5;
    public bool gotkey = false;

    private void Start() 
    {
        key1.SetActive(false);
        collider2D.enabled = false;
    }
    private void Update() {
    {
        if(typer2.complete == true)
        {
            key = true;
            key1.SetActive(true);
            collider2D.enabled = true;
        }
        if(havekey <= 0)
        {
            key = false;
        }
        if(havekey > 0)
        {
            manager.SetTextKeys(havekey);
            key = true;
        }
        
        
    }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player")
        {
            Destroy(key1);
            havekey ++;
            gotkey = true;
            key = true;
            manager.SetTextKeys(havekey);
            collider2D.enabled = false;
        }
    }
    public void UpdateKeys(int keycount)
    {
        havekey = havekey+keycount;
        manager.SetTextKeys(havekey);
    }
}
