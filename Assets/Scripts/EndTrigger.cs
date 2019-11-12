using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter ()
    {
        //Changes to the next scene in the build index
        gameManager.NextScene();
    }
}
