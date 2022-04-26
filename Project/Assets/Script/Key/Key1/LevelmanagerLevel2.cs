using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelmanagerLevel2 : MonoBehaviour
{
    public Keys keys;
    
    public Text uiTextKeys;
    public void SetTextKeys(int havekey)
    {
        uiTextKeys.text = havekey.ToString();
    }
}
