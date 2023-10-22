using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ShowOptions()
    {
        Debug.Log("Show options");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
