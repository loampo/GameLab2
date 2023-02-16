using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{

    public PlayerMovement player;


    private Vector3 m_offset;
    public float m_speed=10f;

    
    public void Start()
    {
        m_offset = new Vector3(10.08f, 6.25f, -16.74f);
    }

    public void Update()
    {
        
        Vector3 playerPosition = player.transform.position;
        transform.position = new Vector3(playerPosition.x, 0, playerPosition.z) + m_offset;
     
    }

    

}