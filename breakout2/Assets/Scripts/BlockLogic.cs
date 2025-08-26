using UnityEngine;
public class BlockLogic : MonoBehaviour
{

    private float randomNumber = 0f;
    [SerializeField] private GameObject ball;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        randomNumber = Random.Range(1, 10);
        Debug.Log(randomNumber);

        if (randomNumber <= 2)
        {
            Instantiate(ball, collision.transform.position, (collision.transform.rotation * Quaternion.Euler(0, -90, 0)));
        }
    }
}
