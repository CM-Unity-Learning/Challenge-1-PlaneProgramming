using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float rotationSpeed = 50.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed);
    }
}
