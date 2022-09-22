using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    float second = 0;
    float minute = 0;

    // Update is called once per frame
    void Update()
    {
        second += Time.deltaTime;
        if (second >= 60)
        {
            minute++;
            second = 0;
        }
        timerText.text = string.Format("{0}:{1:00.00}", minute, second);
        
    }
}
