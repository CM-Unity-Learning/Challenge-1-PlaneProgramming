using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 20.0f;
    private float rotationSpeed = 45.0f;
    private float forwardInput;
    //private float horizontalInput;

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        forwardInput = Input.GetAxis("Vertical");
        //horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right, rotationSpeed * forwardInput * Time.deltaTime);
    }
}
