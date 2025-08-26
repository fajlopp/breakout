using UnityEngine;
using UnityEngine.SceneManagement;

public class BallLogic : MonoBehaviour
{
    private Rigidbody2D ballRb;

    private float minVelocity = 3;
    private float maxVelocity = 5;
    private float minY = -5;

    public ManageScene manageScene;
    public AudioClip destroy;
    public AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
        ballRb.linearVelocityY = -minVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        RestrictSpeed();
        IfBallOut();

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Block")
        {
            audioSource.PlayOneShot(destroy, 0.2f);
            Destroy(collision.gameObject);
        }
    }

    private void RestrictSpeed()
    {
        if (ballRb.linearVelocity.magnitude > maxVelocity)
        {
            ballRb.linearVelocity = Vector2.ClampMagnitude(ballRb.linearVelocity, maxVelocity);
        }

        if (ballRb.linearVelocity.magnitude < minVelocity)
        {
            if (ballRb.linearVelocityY < 0)
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
    }


    private void IfBallOut()
    {
        if (ballRb.position.y < minY)
        {
            Destroy(gameObject);
        }
    }
    
}
