using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //<access-specifier>   <data-type>   <variable-name>
    public Rigidbody rb;
    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        //Movement for both Left and Right
        float inputH = Input.GetAxis("Horizontal");
        float inputV = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(inputH, 0, inputV);
        //Adds force by using physics
        rb.AddForce(direction * speed);

    }
}
