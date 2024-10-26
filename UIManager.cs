using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public Health playerHealth;

    void Update()
    {
        scoreText.text = "Score: " + GameManager.instance.playerScore;
    }

    public void UpdateHealth(int health)
    {
        // Update health UI based on player health
    }
}
