
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    public Vector3 offest;
    // Update is called once per frame
    void Update()
    {
        //allows the camera to be offset from the centre of the screen
        transform.position = player.position + offest;
    }
}
