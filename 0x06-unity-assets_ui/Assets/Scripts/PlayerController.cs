using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    public CharacterController player;
    public float gravity = -9.81f * 2;
    public float jumpHeight = 3.0f;
    Vector3 gravityvector = Vector3.zero;
    bool isGrounded = true;

    void FixedUpdate()
    {
        if (player.isGrounded && gravityvector.y < 0)
        {
            gravityvector.y = -1f;
        }

        isGrounded = player.isGrounded;
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        player.Move(move * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            gravityvector.y = Mathf.Sqrt(jumpHeight * -3f * gravity);
        }

        gravityvector.y += gravity * Time.deltaTime;

        player.Move(gravityvector * Time.deltaTime);
        if (player.transform.position.y < -20)
        {
            player.transform.position = new Vector3(0, 20, 0);
        }
    }
}
