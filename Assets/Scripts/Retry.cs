
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    void Update()
    {
        // Check if the space bar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space bar pressed. Restarting game...");
            // Get the current active scene
            Scene currentScene = SceneManager.GetActiveScene();
            Debug.Log("Current scene: " + currentScene.name);
            // Reload the current scene
            SceneManager.LoadScene(currentScene.name);
        }
    }
}