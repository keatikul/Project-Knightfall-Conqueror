using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Levelmanager : MonoBehaviour
{
    public static Levelmanager instance;
    public Transform respawnPoint;
    public GameObject[] PlayerPrefab;
    public CinemachineVirtualCameraBase cam;
    private int index;
    
    public void GoToHome()
    {
        SceneManager.LoadScene("Home");
    }
    private void Awake() {
        instance = this;
    }
    public void Respawn () {
        index = PlayerPrefs.GetInt("CharacterSelected");
        GameObject player = Instantiate(PlayerPrefab[index], respawnPoint.position, Quaternion.identity);
        cam.Follow = player.transform;
        cam.LookAt = player.transform;
        Debug.Log("Yay is clone");
    }
}