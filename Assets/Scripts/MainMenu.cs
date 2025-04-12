using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("MainGame"); // Replace with your actual game scene name
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("HowToPlay"); // Replace with your actual help scene name
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}


