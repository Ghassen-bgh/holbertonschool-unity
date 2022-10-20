using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    public Animator anim;
    public GameObject player;
    public GameObject cutsceneCamera;
    public GameObject mainCamera;
    public GameObject TimerCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            player.GetComponent<PlayerController>().enabled = true;
            cutsceneCamera.SetActive(false);
            mainCamera.SetActive(true);
            TimerCanvas.SetActive(true);
        }
    }
}
