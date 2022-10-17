using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool Paused = false;

    public GameObject pauseMenuUI;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        void Pause()
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            Paused = true;
        }

        void Resume()
        {
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            Paused = false;
        }

        
    }
    public void ResumeB()
        {
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            Paused = false;
        }
    public void Restart(int levels)
    {
        
        SceneManager.LoadScene(levels);
        Time.timeScale = 1f;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void Options()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1f;
    }
}
