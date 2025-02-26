﻿using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizonalInput;

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical"); // up down
        horizonalInput = Input.GetAxis("Horizontal"); //left and right

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * horizonalInput * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left * Time.deltaTime * verticalInput * rotationSpeed);
    }
}
