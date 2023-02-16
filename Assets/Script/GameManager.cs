using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject menu;
    public GameObject skin;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }
    }

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }

    public void Skin()
    {
        menu.SetActive(false);
        skin.SetActive(true);

    }

    public void ReturnMenu()
    {
        menu.SetActive(true);
        skin.SetActive(false);
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
