using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }
    }

    private void Pause()
    {
        if (Time.timeScale == 0)
        {
            //nPause.SetActive(false);
            Time.timeScale = 1;
        }
        else if (Time.timeScale == 1)
        {
            //nPause.SetActive(true);
            Time.timeScale = 0;
        }
    }

}
