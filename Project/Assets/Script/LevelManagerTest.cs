using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManagerTest : MonoBehaviour
{
    public Text uiTextHeart;

    public int playerHeart = 5;

    public void SetTextHeart(int amount)
    {
        uiTextHeart.text = amount.ToString();
    }
}
