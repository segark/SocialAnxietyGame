using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    // Method to reload the current scene
    public void ReloadCurrentScene()
    {
        // Get the current active scene
        Scene currentScene = SceneManager.GetActiveScene();
        // Load the current scene again
        SceneManager.LoadScene(currentScene.name);
    }

    public void LoadCafeScene()
    {
         SceneManager.LoadScene("TestScene");
    }
    public void LoadPartyScene()
    {
        SceneManager.LoadScene("PartyScene");
    }
    public void LoadPlayerOneScene()
    {
       SceneManager.LoadScene("ShyGirlScene");
    }

    public void LoadPlayerTwoScene()
    {
       SceneManager.LoadScene("ChillGuyScene");
    }

    public void LoadPlayerThreeScene()
    {
       SceneManager.LoadScene("PopularGuyScene");
    }
    public void LoadTutorialScene()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void LoadAbout()
    {
        SceneManager.LoadScene("About");
    }
}
