using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public void Play()
    {

        SceneManager.LoadScene("Advice");
    }
    
    public void Play_game()
    {

        SceneManager.LoadScene("Game");
    }
    
    public void Back()
    {

        SceneManager.LoadScene("HomePage");
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
}
