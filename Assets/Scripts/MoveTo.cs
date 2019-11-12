using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{

    public Transform goal;

    void Start()
    {
        //Allows the Enemy to move
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        //Moves to the waypoints
        agent.destination = goal.position;
    }
}
