using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story2Manager : MonoBehaviour
{
    public void Go_character()
   {
       SceneManager.LoadScene("CharacterSelect");
   }
   public void Go_story1()
   {
       SceneManager.LoadScene("Story1");
   }
   
}
