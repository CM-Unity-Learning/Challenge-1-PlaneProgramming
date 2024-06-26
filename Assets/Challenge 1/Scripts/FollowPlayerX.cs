using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(0, 2, -7);

    // Update is called once per frame
    void Update()
    {
        //Offset the camera behind the player by adding to the player's position
        transform.position = plane.transform.position + offset;
    }
}
