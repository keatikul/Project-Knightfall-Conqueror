using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScreen : MonoBehaviour
{
   public void Start_game()
   {
       SceneManager.LoadScene("Story1");
   }
   public void Credit_game()
   {
       SceneManager.LoadScene("Credit1");
   }
   
   public void Exit_game()
   {
       Application.Quit();
   }
}
