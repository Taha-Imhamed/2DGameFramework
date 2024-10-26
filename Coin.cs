using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.AddScore(coinValue);  // Assuming you have a GameManager that tracks the score
            Destroy(gameObject);  // Destroy the coin after collecting
        }
    }
}
