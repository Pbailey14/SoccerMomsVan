using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Gets the Rigidbody2D component
        ResetBall();
    }

    void ResetBall()
    {
        transform.position = Vector2.zero; // Move ball to center
        rb.linearVelocity = new Vector2(Random.Range(-1f, 1f), Random.Range(-0.5f, 0.5f)) * speed; // Launch ball in random direction
    }
}
