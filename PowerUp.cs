using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float duration = 5f;  // How long the power-up lasts
    public GameObject pickupEffect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }

    IEnumerator Pickup(Collider2D player)
    {
        // Show power-up effect (optional)
        Instantiate(pickupEffect, transform.position, transform.rotation);

        // Apply power-up effect (e.g., increase player speed)
        PlayerMovement playerMovement = player.GetComponent<PlayerMovement>();
        playerMovement.speed *= 2;

        // Disable power-up object
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;

        // Wait for duration
        yield return new WaitForSeconds(duration);

        // Revert player speed back to normal
        playerMovement.speed /= 2;

        // Destroy the power-up
        Destroy(gameObject);
    }
}
