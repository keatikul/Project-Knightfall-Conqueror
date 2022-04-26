using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keyboard : MonoBehaviour
{
    public GameObject imagecon1;
    public GameObject imagecon2;
    public GameObject imagecon3;
    public GameObject imagecon4;
    public GameObject imagecon5;
    public GameObject imagecon6;
    public GameObject imagecon7;
    public GameObject imagecon8;
    public GameObject imagecon9;
    public GameObject imagecon10;
    public GameObject imagecon11;
    public GameObject imagecon12;
    public GameObject imagecon13;
    public GameObject imagecon14;
    public GameObject imagecon15;
    public GameObject imagecon16;
    public GameObject imagecon17;
    public GameObject imagecon18;
    public GameObject imagecon19;
    public GameObject imagecon20;
    public GameObject imagecon21;
    public GameObject imagecon22;
    public GameObject imagecon23;
    public GameObject imagecon24;
    public GameObject imagecon25;
    public GameObject imagecon26;
    

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }
    private void CheckInput()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            imagecon1.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            imagecon2.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            imagecon3.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            imagecon4.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.T))
        {
            imagecon5.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.Y))
        {
            imagecon6.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.U))
        {
            imagecon7.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.I))
        {
            imagecon8.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.O))
        {
            imagecon9.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.P))
        {
            imagecon10.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            imagecon11.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            imagecon12.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            imagecon13.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.F))
        {
            imagecon14.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.G))
        {
            imagecon15.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.H))
        {
            imagecon16.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.J))
        {
            imagecon17.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.K))
        {
            imagecon18.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.L))
        {
            imagecon19.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.Z))
        {
            imagecon20.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.X))
        {
            imagecon21.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            imagecon22.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.V))
        {
            imagecon23.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.B))
        {
            imagecon24.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.N))
        {
            imagecon25.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon26.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
        if(Input.GetKeyDown(KeyCode.M))
        {
            imagecon26.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            imagecon2.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon3.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon4.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon5.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon6.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon7.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon8.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon9.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon10.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon11.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon12.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon13.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon14.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon15.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon16.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon17.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon18.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon19.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon20.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon21.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon22.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon23.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon24.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon25.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            imagecon1.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }
}
