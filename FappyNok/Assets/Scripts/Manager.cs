using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
}
