using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Load Mad Driver game
    public void LoadMadDriver()
    {
        SceneManager.LoadScene("MadDriver");
    }

    // Load Fly Like a Bird game
    public void LoadFlyLikeABird()
    {
        SceneManager.LoadScene("FlyLikeABird");
    }

    // Load I'm a Sumo and a Ball game
    public void LoadSumoAndBall()
    {
        SceneManager.LoadScene("SumoAndBall");
    }

    // Exit the game
    public void ExitGame()
    {
        Debug.Log("Exiting game...");
        Application.Quit();

        // For Unity Editor testing
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
