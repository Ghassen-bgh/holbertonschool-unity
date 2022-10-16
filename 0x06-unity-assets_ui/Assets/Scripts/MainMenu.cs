using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public void LevelSelect(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void QuitGame()
    {
        Debug.Log("Exited");
        Application.Quit();
    }

    public void Options()
    {
        SceneManager.LoadScene(4);
    }


}
