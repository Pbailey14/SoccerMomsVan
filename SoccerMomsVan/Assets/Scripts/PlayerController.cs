using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public bool isPlayerOne; // True = WASD, False = Arrow Keys
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement = Vector2.zero; // Reset movement each frame

        if (isPlayerOne) // Player 1 uses WASD
        {
            if (Input.GetKey(KeyCode.W)) movement.y = 1;
            if (Input.GetKey(KeyCode.S)) movement.y = -1;
            if (Input.GetKey(KeyCode.A)) movement.x = -1;
            if (Input.GetKey(KeyCode.D)) movement.x = 1;
        }
        else // Player 2 uses Arrow Keys
        {
            if (Input.GetKey(KeyCode.UpArrow)) movement.y = 1;
            if (Input.GetKey(KeyCode.DownArrow)) movement.y = -1;
            if (Input.GetKey(KeyCode.LeftArrow)) movement.x = -1;
            if (Input.GetKey(KeyCode.RightArrow)) movement.x = 1;
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movement.normalized * speed; // Normalize to avoid faster diagonal movement
    }
}
