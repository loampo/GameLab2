using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovementObject : MonoBehaviour
{
    public float minSpeedX;
    public float maxSpeedX;

   



    public void Update()
    {
        transform.position += new Vector3(Random.Range(minSpeedX,maxSpeedX) * Time.deltaTime, 0.0f, 0.0f);
    }




}
