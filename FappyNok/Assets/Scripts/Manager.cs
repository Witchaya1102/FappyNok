using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public void click()
    {
        GetComponent<Animation>().Play("Button_Click");
    }
    public void Play()
    {

        SceneManager.LoadScene("Game");
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
}
