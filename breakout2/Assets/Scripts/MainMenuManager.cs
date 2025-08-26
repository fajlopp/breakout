using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour
{
    public void ChangeToMain()
    {
        SceneManager.LoadScene("Main");
    }
    
}
