using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerdeath : MonoBehaviour
{
    private bool hasEntered;
    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Enemylevel" && !hasEntered) {
            hasEntered = true;
            Destroy(gameObject);
            Levelmanager.instance.Respawn();
        }
}
}
