using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private Vector2 checkpointPosition;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            checkpointPosition = other.transform.position;
        }
    }

    public Vector2 GetCheckpointPosition()
    {
        return checkpointPosition;
    }
}
