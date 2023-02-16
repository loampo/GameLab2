using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    
    public Rigidbody m_Rb;
    public float m_jumpForce = 100f;
    bool m_canJump = false;
    public GenerateMap generateMap;
    public bool m_isMove;
    public bool m_facing;



    // Start is called before the first frame update
    void Start()
    {
        m_Rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(Mathf.Abs(m_Rb.velocity.y) < 0.001f) //Ground check
        {
            m_canJump = true;

        }
        else
        {
            m_canJump = false;

        }
        if (m_canJump) 
        {
                if (Input.GetKey(KeyCode.UpArrow)) 
                {
                    m_facing = false;
                    m_isMove = true;
                    RotationAndPosition(new Vector3(0, 0, 0));
                    //addForce physic movement 
                    m_Rb.AddForce(new Vector3(0, m_jumpForce, m_jumpForce));
                    moveCharacter(new Vector3(1, 0, 0));
                    

                }
                else if (Input.GetKey(KeyCode.RightArrow))
                {
                    m_facing = true;
                    m_isMove = true;
                    RotationAndPosition(new Vector3(0, 90, 0));
                    //addForce physic movement 
                    m_Rb.AddForce(new Vector3(m_jumpForce, m_jumpForce, 0));
                    moveCharacter(new Vector3(0, 0, -1));
                    
                }
                else if (Input.GetKey(KeyCode.DownArrow))
                {
                    m_facing = false;
                    m_isMove = true;
                    RotationAndPosition(new Vector3(0, 180, 0));
                    //addForce physic movement 
                    m_Rb.AddForce(new Vector3(0, m_jumpForce, -m_jumpForce)); 
                    moveCharacter(new Vector3(-1, 0, 0));

                }
                else if (Input.GetKey(KeyCode.LeftArrow))
                {
                    m_facing = true;
                    m_isMove = true;
                    RotationAndPosition(new Vector3(0, -90, 0));
                    //addForce physic movement 
                    m_Rb.AddForce(new Vector3(-m_jumpForce, m_jumpForce, 0));
                    moveCharacter(new Vector3(0, 0, 1));
                    
                }
        }
        else
        {
            m_isMove = false;
        }
        

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cars"))
        {
           Scene currentScene = SceneManager.GetActiveScene();
           SceneManager.LoadScene(currentScene.name);
        }
    }


    void RotationAndPosition(Vector3 newRotation)
    {
        m_Rb.velocity = Vector3.zero;
        transform.eulerAngles = newRotation; //Transform.eulerAngles represents rotation in world space. 
        //transform position in a new position fix rotation and position.
        transform.position = new Vector3(Mathf.Round(transform.position.x),transform.position.y, Mathf.Round(transform.position.z));
        
    }



    private void moveCharacter(Vector3 difference)
    {
        //i'm going to take player position 
        generateMap.SpawnTerrain(false, transform.position);
    }

}
