using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("TutorialScene");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
