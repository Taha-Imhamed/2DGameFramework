using UnityEngine;

public class PhysicsCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            GetComponent<Health>().TakeDamage(20);  // Take damage when hitting an enemy
        }
    }
}
