using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Story3Manager : MonoBehaviour
{
    public void Go_story4()
   {
       SceneManager.LoadScene("Story4");
   }
   public void Go_back()
   {
       SceneManager.LoadScene("CharacterSelect");
   }
    
}
