using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelmanagerLevel5 : MonoBehaviour
{
    public Keys keys;
    //public Keys1 keys1;
    public Text uiTextKeys;
    // Start is called before the first frame update
    public void SetTextKeys(int havekey)
    {
        uiTextKeys.text = havekey.ToString();
    }
}
