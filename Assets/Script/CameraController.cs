using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //public Transform target;
    public float distance = 8f;


    //void Update()
    //{
    //    //transform.position = new Vector3(target.position.x, transform.position.y, target.position.z);
    //    transform.position = target.position - transform.forward * distance;
    //}

    public string m_tagToFollow;

    private void LateUpdate()
    {
        GameObject objectToFollow = GameObject.FindWithTag(m_tagToFollow);
        if (objectToFollow != null)
        {
            transform.position = objectToFollow.transform.position - transform.forward * distance;
        }
    }
}
