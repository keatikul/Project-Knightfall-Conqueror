using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story1Manager : MonoBehaviour
{
    public void Go_story2()
   {
       SceneManager.LoadScene("Story2");
   }
  
}
