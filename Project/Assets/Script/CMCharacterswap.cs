using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
namespace Player
{
    public class CMCharacterswap : MonoBehaviour
    {
        [SerializeField]
        private GameObject[] Characters;
        private int index;
        private CinemachineVirtualCamera CMcam;
        private GameObject tPlayer;
        private Transform tFollowTarget;
 
    private void Start()
        {
            CMcam = GetComponent<CinemachineVirtualCamera>();
         
           index = PlayerPrefs.GetInt("CharacterSelected");
            if (Characters[index])
                   CMcam.Follow = Characters[index].transform;
        }
    }
}