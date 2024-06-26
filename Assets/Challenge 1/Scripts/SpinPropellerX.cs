using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float rotationSpeed = 1000;
    private float horizonalInput;

    // Update is called once per frame
    void Update()
    {
        horizonalInput = Input.GetAxis("Horizontal"); //left and right

        transform.Rotate(Vector3.forward * Time.deltaTime * horizonalInput * rotationSpeed);
    }
}
