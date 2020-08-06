using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject SettingsCanvas;
    public GameObject MainMenuCanvas;

    public void onStartGamePressed()
    {
        SceneManager.LoadSceneAsync((int) LevelEnum.FirstLevel);
    }

    public void onSettingsPressed()
    {
        MainMenuCanvas.SetActive(false);
        SettingsCanvas.SetActive(true);
    }

    public void onExitPressed()
    {
        Application.Quit();
    }
}
