using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipsLevel1 : MonoBehaviour
{
   public Typer1 typer1;
   public Typer2 typer2;
   public Typer3 typer3;
   public Typer4 typer4;
   public Typer5 typer5;
   public GameObject tips1;
   public GameObject tips2;
   public GameObject tips3;
   public GameObject tips4;
   public GameObject tips5;
   



    // Update is called once per frame
    void Update()
    {

        if(typer1.complete1 == true)
        {
            typer2.complete2 = false;
            typer3.complete3 = false;
            typer4.complete4 = false;
            typer5.complete5 = false;
            tips1.SetActive(true);
            tips5.SetActive(false);
            tips2.SetActive(false);
            tips3.SetActive(false);
            tips4.SetActive(false);
        }
        if(typer2.complete2 == true)
        {
            typer5.complete5 = false;
            typer3.complete3 = false;
            typer4.complete4 = false;
            typer1.complete1 = false;
            tips2.SetActive(true);
            tips1.SetActive(false);
            tips5.SetActive(false);
            tips3.SetActive(false);
            tips4.SetActive(false);
        }
        if(typer3.complete3 == true)
        {
            typer2.complete2 = false;
            typer5.complete5 = false;
            typer4.complete4 = false;
            typer1.complete1 = false;
            tips3.SetActive(true);
            tips1.SetActive(false);
            tips2.SetActive(false);
            tips5.SetActive(false);
            tips4.SetActive(false);
        }
        if(typer4.complete4 == true)
        {
            typer2.complete2 = false;
            typer3.complete3 = false;
            typer1.complete1 = false;
            typer5.complete5 = false;
            tips4.SetActive(true);
            tips1.SetActive(false);
            tips2.SetActive(false);
            tips3.SetActive(false);
            tips5.SetActive(false);
        }
        if(typer5.complete5 == true)
        {
            typer2.complete2 = false;
            typer3.complete3 = false;
            typer4.complete4 = false;
            typer1.complete1 = false;
            tips5.SetActive(true);
            tips1.SetActive(false);
            tips2.SetActive(false);
            tips3.SetActive(false);
            tips4.SetActive(false);
        }
    }
}
