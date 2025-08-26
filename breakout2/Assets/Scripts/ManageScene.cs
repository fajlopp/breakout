using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static Unity.Collections.AllocatorManager;
using UnityEngine.SceneManagement;
public class ManageScene : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI blocksLeft;
    [SerializeField] private GameObject gameOverScreen;

     public BallLogic ballLogic;


    void Update()
    {
        CountBlocks();
        IsGameOver();
         
    }

    private void CountBlocks()
    {
        GameObject[] existingBlocks = GameObject.FindGameObjectsWithTag("Block");
        int countBlocks = existingBlocks.Length;
        blocksLeft.text = "Number of blocks left: " + countBlocks;
    }

    public void OnClick()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private void IsGameOver()
    {
        if (ballLogic.gameOver == true)
        {
            gameOverScreen.SetActive(true);
        }
    }
}

