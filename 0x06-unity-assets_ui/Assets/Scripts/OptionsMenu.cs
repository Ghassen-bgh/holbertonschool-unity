using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    private bool on;
    public Toggle isinver;
    public void Back()
    {

        int currentLevels = PlayerPrefs.GetInt("previous", 0);
        SceneManager.LoadScene(currentLevels);
    }
    public void Apply()
    {
        Invert();
        Back();
    }
    public void Invert()
    {
        on = isinver.isOn;
        if (on)
        {
            PlayerPrefs.SetInt("__inverted",1);
        }
        else
        {
            PlayerPrefs.SetInt("__inverted",0);
        }
    }
}