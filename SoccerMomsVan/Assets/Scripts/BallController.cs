using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 8f;
    public float slowDownFactor = 0.99f; // Slows the ball slightly each frame
    private Rigidbody2D rb;
    private bool hasStarted = false; // Prevents the ball from moving until hit

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = Vector2.zero; // Start stationary
        transform.position = Vector2.zero; // Center the ball
    }

    void Update()
    {
        if (hasStarted)
        {
            rb.linearVelocity *= slowDownFactor; // Gradually slow down the ball
        }
    }

    public void ResetBall()
    {
        transform.position = Vector2.zero; // Move ball to center
        rb.linearVelocity = Vector2.zero; // Stop movement
        hasStarted = false; // Ball needs to be hit again
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!hasStarted && (collision.gameObject.CompareTag("Player1") || collision.gameObject.CompareTag("Player2")))
        {
            hasStarted = true;
            rb.linearVelocity = new Vector2(Random.Range(-1f, 1f), Random.Range(-0.5f, 0.5f)).normalized * speed;
        }
    }
}