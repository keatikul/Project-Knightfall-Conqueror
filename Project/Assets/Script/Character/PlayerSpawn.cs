using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
 
public class PlayerSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] PlayerSpawnLocation;
    [SerializeField]
    private GameObject[] Characters;
    private int index;
    [SerializeField]
    private CinemachineVirtualCamera CMcam;
 
    void Awake()
    {
        
        index = PlayerPrefs.GetInt("CharacterSelected");
        int spawn = Random.Range(0, PlayerSpawnLocation.Length);
        GameObject player = Characters[index];
        player = Instantiate(Characters[index], PlayerSpawnLocation[spawn].transform.position, Quaternion.identity);
        if (Characters[index])
        {
            CMcam.Follow = player.transform;
            CMcam.LookAt = player.transform;
        }
    }
    

}