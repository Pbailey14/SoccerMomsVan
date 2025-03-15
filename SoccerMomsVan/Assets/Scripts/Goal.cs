using UnityEngine;

public class Goal : MonoBehaviour
{
    public int playerNumber; // Assign in Inspector

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            BallController ball = collision.GetComponent<BallController>();
            if (ball != null)
            {
                ball.ResetBall();
            }
        }
    }
}