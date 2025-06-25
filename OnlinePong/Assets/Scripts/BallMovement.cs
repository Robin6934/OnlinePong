using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Launch in a random direction
        Vector2 direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        rb.linearVelocity = direction * speed;
    }
}