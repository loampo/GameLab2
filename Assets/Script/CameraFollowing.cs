using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowing : MonoBehaviour
{

    public float speedOffsetZ = 4.0f;



    private GameObject player;
    private PlayerMovement playerMovement;

    private Vector3 offset;
    public float speed=10f;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerMovement = player.GetComponent<PlayerMovement>();

        offset = new Vector3(10.08f, 6.25f, -16.74f);

    }

    public void Update()
    {
        

        Vector3 playerPosition = player.transform.position;
        transform.position = new Vector3(playerPosition.x, 0, playerPosition.z) + offset;


    }
}