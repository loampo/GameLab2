using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;



public class PlayerMovement : MonoBehaviour
{
    
    public Rigidbody m_Rb;
    public GameObject player;
    public GameObject playerDeath;
    public float m_jumpForce = 115f;
    bool m_canJump = false;
    public GenerateMap generateMap;
    public LogSpawn logSpawn;
    public TextMeshProUGUI m_scoreText;
    private float m_score = 0f;
    public TextMeshProUGUI m_scoreTextCoins;
    private float m_scoreCoins = 0f;
    public TextMeshProUGUI m_maxScoreText;
    private Vector3 offsetPlayerDeath;
    

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
    
                    RotationAndPosition(new Vector3(0, 0, 0));
                    //addForce physic movement 
                    m_Rb.AddForce(new Vector3(0, m_jumpForce, m_jumpForce));
                    moveCharacter(new Vector3(1, 0, 0));
                    m_score += 1f;
                    m_scoreText.text = m_score.ToString();


                }
                else if (Input.GetKey(KeyCode.RightArrow))
                {

                    RotationAndPosition(new Vector3(0, 90, 0));
                    //addForce physic movement 
                    m_Rb.AddForce(new Vector3(m_jumpForce, m_jumpForce, 0));
                    moveCharacter(new Vector3(0, 0, -1));
                    
                }
                else if (Input.GetKey(KeyCode.DownArrow))
                {

                    RotationAndPosition(new Vector3(0, 180, 0));
                    //addForce physic movement 
                    m_Rb.AddForce(new Vector3(0, m_jumpForce, -m_jumpForce)); 
                    moveCharacter(new Vector3(-1, 0, 0));
                    m_score -= 1f;
                    m_scoreText.text = m_score.ToString();
                
                }
                else if (Input.GetKey(KeyCode.LeftArrow))
                {

                    RotationAndPosition(new Vector3(0, -90, 0));
                    //addForce physic movement 
                    m_Rb.AddForce (new Vector3 (-m_jumpForce, m_jumpForce, 0));
                    moveCharacter(new Vector3(0, 0, 1));
                    
                }
        }
        m_maxScoreText.text = m_score.ToString();
        

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cars"))
        {
            offsetPlayerDeath = new Vector3(0f, 0.4f, 0f);
            player.SetActive(false);
            playerDeath.transform.position = player.transform.position - offsetPlayerDeath ;
            playerDeath.SetActive(true);
           // Scene currentScene = SceneManager.GetActiveScene();
           //SceneManager.LoadScene(currentScene.name);
        }
        if (other.CompareTag("Water"))
        {
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.name);
        }
        if (other.CompareTag("Coins"))
        {
            Destroy(other.gameObject);
            m_scoreCoins += 1f;
            m_scoreTextCoins.text = m_scoreCoins.ToString();
        }
    }

    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Logs1")
        {
            m_Rb.position += new Vector3(-2 * Time.deltaTime, 0.0f, 0.0f);
 
        }
        if (collision.gameObject.tag == "Logs")
        {
            m_Rb.position += new Vector3(2 * Time.deltaTime, 0.0f, 0.0f);
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
