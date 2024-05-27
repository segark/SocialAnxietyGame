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
}
