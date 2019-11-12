using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerForceMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
  

    // Update is called once per frame
    void FixedUpdate()
    {
        //Movement for both left and right by using physics on there axis
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }


    }

}
