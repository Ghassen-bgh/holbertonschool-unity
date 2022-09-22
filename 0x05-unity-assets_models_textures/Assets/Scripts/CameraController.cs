using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;
    public float turnSpeed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position;
        
    }

    void LateUpdate()
    {
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
        Vector3 newPos = player.position + offset;
        transform.position = newPos;
        transform.LookAt(player.position);
        player.Rotate(Input.GetAxis("Mouse X") * turnSpeed * Vector3.up);
    }
}
