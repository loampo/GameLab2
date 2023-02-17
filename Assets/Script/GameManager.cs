using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject menu;
    public GameObject skin;
    public GameObject gameManager;



    // Update is called once per frame

    private void Start()
    {
        DontDestroyOnLoad(gameManager);
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
    
    

}
