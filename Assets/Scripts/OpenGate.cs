using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour
{
    public Animation openGate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        //Makes an animation occur when E is pressed on the door object
        if (Input.GetKey(KeyCode.E))
            openGate.Play();
    }
}
