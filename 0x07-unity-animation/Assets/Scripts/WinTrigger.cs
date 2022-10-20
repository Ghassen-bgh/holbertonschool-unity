using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class WinTrigger : MonoBehaviour
{
    public GameObject Player;

    public TextMeshProUGUI win_text;
    public GameObject winCanvas;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player.gameObject.GetComponent<Timer>().enabled = false;
            win_text.text = "";
            winCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}