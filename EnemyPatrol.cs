using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float patrolSpeed = 2f;
    public Transform pointA, pointB;  // Patrol points
    private bool movingToB = true;

    void Update()
    {
        if (movingToB)
        {
            transform.position = Vector2.MoveTowards(transform.position, pointB.position, patrolSpeed * Time.deltaTime);
            if (Vector2.Distance(transform.position, pointB.position) < 0.1f) movingToB = false;
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, pointA.position, patrolSpeed * Time.deltaTime);
            if (Vector2.Distance(transform.position, pointA.position) < 0.1f) movingToB = true;
        }
    }
}
