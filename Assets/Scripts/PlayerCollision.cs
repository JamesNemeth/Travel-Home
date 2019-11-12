using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerForceMovement movement;
    void OnCollisionEnter(Collision collisioninfo)
    {
        //If an object is tagged as Obstacle...
        if (collisioninfo.collider.tag == "Obstacle")
        {
            //Stops movement
            movement.enabled = false;
        }
    }
}
