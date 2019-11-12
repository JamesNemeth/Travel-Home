using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public Component gatecolliderhere;
    public GameObject keygone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerStay ()
    {
        //Grabs the key object 
        if(Input.GetKey(KeyCode.E))
        gatecolliderhere.GetComponent<BoxCollider>().enabled = true;

        //Destroys the game object once used
        if (Input.GetKey(KeyCode.E))
        keygone.SetActive(false);
    }
}
