using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class WinTrigger : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    Timer timer;
    public GameObject player;
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
            player = GameObject.Find("Player");
        timer = player.GetComponent<Timer>();
        timer.enabled = false;
        timerText.color = Color.green;
        timerText.fontSize = 60;
    }
}
