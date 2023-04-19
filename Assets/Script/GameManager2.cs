using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager2 : MonoBehaviour
{

    public GameObject pause;
    public GameManager gameManager;
    public GameObject playerSkin1;
    public GameObject playerSkin2;
    public GameObject playerSkin3;
    public GameObject playerSkin4;
    public GameObject playerSkin5;
    public GameObject playerSkin6;


    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        if (gameManager.redSkin == true)
        {
            playerSkin1.SetActive(false);
            playerSkin2.SetActive(false);
            playerSkin3.SetActive(false);
            playerSkin4.SetActive(false);
            playerSkin5.SetActive(false);
            playerSkin6.SetActive(false);
        }
        if (gameManager.blueSkin == true)
        {
            playerSkin1.SetActive(false);
            playerSkin2.SetActive(false);
            playerSkin3.SetActive(true);
            playerSkin4.SetActive(false);
            playerSkin5.SetActive(false);
            playerSkin6.SetActive(false);
        }
        if (gameManager.pinguinoSkin == true)
        {
            playerSkin1.SetActive(false);
            playerSkin2.SetActive(false);
            playerSkin3.SetActive(false);
            playerSkin4.SetActive(true);
            playerSkin5.SetActive(false);
            playerSkin6.SetActive(false);
        }
        if (gameManager.rhinoSkin == true)
        {
            playerSkin1.SetActive(false);
            playerSkin2.SetActive(false);
            playerSkin3.SetActive(false);
            playerSkin4.SetActive(false);
            playerSkin5.SetActive(true);
            playerSkin6.SetActive(false);
        }
        if (gameManager.perrySkin == true)
        {
            playerSkin1.SetActive(false);
            playerSkin2.SetActive(false);
            playerSkin3.SetActive(false);
            playerSkin4.SetActive(false);
            playerSkin5.SetActive(false);
            playerSkin6.SetActive(true);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }

       










    }

    public void Pause()
    {
        if (Time.timeScale == 0)
        {
            pause.SetActive(false);
            Time.timeScale = 1;

        }
        else if (Time.timeScale == 1)
        {
            pause.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void RestartGame()
    {
        //Scene currentScene = SceneManager.GetActiveScene();
        //SceneManager.LoadScene(currentScene.name);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ReturnLobby()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex - 1);
    }


}
