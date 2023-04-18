using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class snake : MonoBehaviour
{
    public Vector3 currentPosition = Vector3.right;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            currentPosition = Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            currentPosition = Vector3.down;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            currentPosition = Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            currentPosition = Vector3.right;
        }
    }

    private void FixedUpdate()
    {
        transform.position += currentPosition;
    }
}