using UnityEngine;

public class Goal : MonoBehaviour
{
    public int playerNumber; // This should now appear in the Inspector

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball")) // Ensure the ball has the tag "Ball"
        {
            Debug.Log("Goal scored by Player " + playerNumber);
            collision.GetComponent<BallController>().ResetBall();
        }
    }
}