using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{

    public PlayerMovement player;

    //private GameObject player;
    //private PlayerMovement playerMovement;

    private Vector3 m_offset;
    public float m_speed=10f;

    
    public void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
        //playerMovement = player.GetComponent<PlayerMovement>();

        m_offset = new Vector3(10.08f, 6.25f, -16.74f);

    }

    public void Update()
    {
        if (player.m_isMove&&!player.m_facing)
        {
            Vector3 playerPosition = player.transform.position;
            transform.position = new Vector3(playerPosition.x, 0, playerPosition.z) + m_offset;
        }else if(!player.m_isMove)
        {
            transform.position += new Vector3(0f, 0f, m_speed * Time.deltaTime);
        }/*else if (player.facing)*/
        //{
        //    transform.rotation = new Quaternion(90);
        //}

        


    }

    

}