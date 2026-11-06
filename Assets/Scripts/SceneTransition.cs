using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadSceneAsync("GameScene");
    }

    public void MainMenuGame()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
