using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FollowThePath : MonoBehaviour
{

    public Transform[] waypoints;

    //private float moveSpeed = 1f;
    public int waypointIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        waypoints = GameManager.Instance.waypoints;
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Mueve la ficha una determinada cantidad de casillas
    public void Move(int x){

        if (waypointIndex + x > waypoints.Length - 1)
        {
            waypointIndex = (waypointIndex + x) - (waypoints.Length -1);
        }
        else
        {
            waypointIndex = waypointIndex + x;
        }

        transform.position = waypoints[waypointIndex].transform.position;

    }
}
