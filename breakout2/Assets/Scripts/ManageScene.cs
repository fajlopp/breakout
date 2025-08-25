using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static Unity.Collections.AllocatorManager;
public class ManageScene : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI blocksLeft;

    private void Update()
    {
        CountBlocks();
         
    }

    private void CountBlocks()
    {
        GameObject[] existingBlocks = GameObject.FindGameObjectsWithTag("Block");
        int countBlocks = existingBlocks.Length;
        blocksLeft.text = "Number of blocks left: " + countBlocks;
    }
}

