using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    //camera speed
    public float speed = 1.0f;
    public GameObject Manatee;

    //positions
    private Transform target;
       void moveForward()
    {
        //move Camera
        Camera.main.transform.position = new Vector3(1.18f, 5.76f, -30.45f);
    }
}
