using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager2 : MonoBehaviour
{

    public GameObject pause;

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
