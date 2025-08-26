using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerRb;
    public float moveSpeed = 8f;
    public ManageScene manageScene;

    float horizontalMovement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMoves();
    }

    public void Move(InputAction.CallbackContext context)
    {
        horizontalMovement = context.ReadValue<Vector2>().x;
    }

    private void PlayerMoves() 
    {
        if (manageScene.gameOver != true && manageScene.gameWon != true)
        {
            playerRb.linearVelocity = new Vector2(horizontalMovement * moveSpeed, 0);
        }
    }
}
