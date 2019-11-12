using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform waypointParent;
    public float waypointDistance = 5f;

    private Transform[] points;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnDrawGizmos()
    {
        //Grabs an object to be the parert for the points
        points = waypointParent.GetComponentsInChildren<Transform>();

        if (points != null)
        {
            Gizmos.color = Color.blue;
            for (int i = 0; i < points.Length - 1; i++)
            {
                //Gives the objects a index number to know what order the AI has to go to
                Transform pointA = points[i];
                Transform pointB = points[i + 1];
                //Draws a long in between waypoints
                Gizmos.DrawLine(pointA.position, pointB.position);
            }

            foreach (var point in points)
            {
                //Draws a Sphere on waypoints
                Gizmos.DrawSphere(point.position, waypointDistance);
            }
        }
    }
}
