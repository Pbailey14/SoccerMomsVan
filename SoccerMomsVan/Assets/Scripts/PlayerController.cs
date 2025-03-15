using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public bool isPlayerOne; // Toggle for Player1 or Player2
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float move = 0;
        if (isPlayerOne)
        {
            move = Input.GetAxisRaw("Vertical"); // Uses W and S
        }
        else
        {
            move = Input.GetAxisRaw("Vertical2"); // Uses Up and Down Arrow keys
        }
        rb.linearVelocity = new Vector2(0, move * speed);
    }
}