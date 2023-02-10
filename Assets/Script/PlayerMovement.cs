using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    
    public Rigidbody _Rb;
    public float jumpForce = 100f;
    bool canJump = false;
    public string moveDirection;


    // Start is called before the first frame update
    void Start()
    {
        _Rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(Mathf.Abs(_Rb.velocity.y) < 0.001f)
        {
            canJump = true;
        }
        else
        {
            canJump = false;
        }
        if (canJump) //Ground check
        {
                if (Input.GetKey(KeyCode.UpArrow)) 
                {
                    RotationAndPosition(new Vector3(0, 0, 0));
                    _Rb.AddForce(new Vector3(0,jumpForce,jumpForce));
                    
                }
                else if (Input.GetKey(KeyCode.RightArrow))
                {
                    RotationAndPosition(new Vector3(0, 90, 0));
                    _Rb.AddForce(new Vector3(jumpForce, jumpForce, 0));
                    
                }
                else if (Input.GetKey(KeyCode.DownArrow))
                {
                    RotationAndPosition(new Vector3(0, 180, 0));
                    _Rb.AddForce(new Vector3(0, jumpForce, -jumpForce));
                    
                }
                else if (Input.GetKey(KeyCode.LeftArrow))
                {
                    RotationAndPosition(new Vector3(0, -90, 0));
                    _Rb.AddForce(new Vector3(-jumpForce, jumpForce, 0));
                    
                }
        }
        

    }

    void RotationAndPosition(Vector3 newRotation)
    {
        _Rb.velocity = Vector3.zero;
        transform.eulerAngles = newRotation; //Transform.eulerAngles represents rotation in world space. 
        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Round(transform.position.z)); 
    }




}
