using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float playerSpeed = 10f;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.forward * playerSpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.back * playerSpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.left * playerSpeed;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.right * playerSpeed;
        }
    }
}
