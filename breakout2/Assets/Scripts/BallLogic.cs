using UnityEngine;
using UnityEngine.SceneManagement;

public class BallLogic : MonoBehaviour
{
    private Rigidbody2D ballRb;
    private Vector2 v;
    public float minVelocity;
    public float maxVelocity;
    public float minY;
    private float gameOverHeight = -5.2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        ballRb.linearVelocityY = -minVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        if(ballRb.linearVelocity.magnitude > maxVelocity)
        {
            ballRb.linearVelocity = Vector2.ClampMagnitude(ballRb.linearVelocity, maxVelocity);
        }

        if(ballRb.linearVelocity.magnitude < minVelocity)
        {
            if(ballRb.linearVelocityY < 0)
            {
                ballRb.linearVelocityY = -minVelocity;
            }
        }

        if (ballRb.linearVelocity.magnitude < minVelocity)
        {
            if (ballRb.linearVelocityY > 0)
            {
                ballRb.linearVelocityY = minVelocity;
            }
        }
        if (ballRb.position.y < gameOverHeight)
        {
            SceneManager.LoadScene("Main");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Block")
        {
            Destroy(collision.gameObject);
        }
    }
}
