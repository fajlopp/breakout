using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static Unity.Collections.AllocatorManager;
using UnityEngine.SceneManagement;
public class ManageScene : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI blocksLeft;
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject gameWonScreen;

    public BallLogic ballLogic;
    public int ballsCounter;
    public int countBlocks;
    public bool gameOver = false;
    public bool gameWon = false;
    


    void Update()
    {
        CountBlocks();
        CountBalls();
        IsGameOver();
        IsGameWon();
    }

    private void CountBlocks()
    {
        GameObject[] existingBlocks = GameObject.FindGameObjectsWithTag("Block");
        countBlocks = existingBlocks.Length;
        blocksLeft.text = "Number of blocks left: " + countBlocks;
    }

    public void CountBalls()
    {
        GameObject[] existingBalls = GameObject.FindGameObjectsWithTag("Ball");
        ballsCounter = existingBalls.Length;
        Debug.Log(ballsCounter);
    }

    public void ChangeToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void IsGameOver()
    {
        if (ballsCounter == 0)
        {
            gameOver = true;
            if (gameOver == true)
            {
                gameOverScreen.SetActive(true);
            }
        }
        
    }

    private void IsGameWon()
    {
        if (countBlocks == 0)
        {
            gameWon = true;
            if (gameWon == true)
            {
                gameWonScreen.SetActive(true);
            }
        }
    }

}

