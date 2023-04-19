using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{

    public PlayerMovement player;

    private Vector3 m_offset;

    
    public void Start()
    {
        m_offset = new Vector3(1f, 1f, -11f);
    }

    public void Update()
    {
        
        Vector3 playerPosition = player.transform.position;
        transform.position = new Vector3(playerPosition.x, 0, playerPosition.z) + m_offset;
     
    }

    

}