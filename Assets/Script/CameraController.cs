using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float distance = 10f;


    void Update()
    {
        //transform.position = new Vector3(target.position.x, transform.position.y, target.position.z);
        transform.position = target.position - transform.forward * distance;
    }
}
