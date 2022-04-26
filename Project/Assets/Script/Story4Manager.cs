using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story4Manager : MonoBehaviour
{
    public void Go_Level1()
   {
       SceneManager.LoadScene("Level1");
   }
   public void Go_story3()
   {
       SceneManager.LoadScene("Story3");
   }
}
