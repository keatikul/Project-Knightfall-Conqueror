using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHeart : MonoBehaviour
{
    public int hearts = 5;
    public int maxHeart = 5;
    [SerializeField] HeartSystem hs;
    private void Start() {
        hs.DrawHeart(hearts, maxHeart);
    }

    private void Update() {
        if(hearts <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    public void DamagePlayer(int dmg)
    {
        if (hearts > 0) {
            hearts -= dmg;
            hs.DrawHeart(hearts, maxHeart);
        }
    }

    public void HealPlayer(int dmg) {
        if (hearts < maxHeart) {
            hearts += dmg;
            hs.DrawHeart(hearts, maxHeart);
        }
    }
}
