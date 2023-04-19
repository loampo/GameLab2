using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject menu;
    public GameObject skin;
    public GameObject gameManager;
    private int m_score = 0;
    public TextMeshProUGUI m_scoreTextCoins;
    //private int m_scoreCoins = 0;
    private int m_maxScore = 0;
    public TextMeshProUGUI m_maxScoreText;
    public bool redSkin;
    public bool blueSkin;
    public bool pinguinoSkin;
    public bool rhinoSkin;
    public bool perrySkin;
    public GameObject needMoreScore;
    public GameObject needMoreScoreCoins;




    // Update is called once per frame

    private void Start()
    {
        int savedScore = PlayerPrefs.GetInt("MaxScore", 0);
        m_maxScoreText.text = "" + savedScore;
        int savedCoin = PlayerPrefs.GetInt("coin", 0);
        m_scoreTextCoins.text = "" + savedCoin;
        int m_MaxScore = PlayerPrefs.GetInt("MaxScore", 0);
        DontDestroyOnLoad(gameManager);
        redSkin = false;
        blueSkin = false;
        pinguinoSkin = false;
        rhinoSkin=false;
        perrySkin = false;
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
        needMoreScore.SetActive(false);

    }
    
    public void SkinPolloRosso()
    {
        int m_MaxScore = PlayerPrefs.GetInt("MaxScore", 0);
        if (m_MaxScore >= 30)
        {
            redSkin = true;
            m_MaxScore -= 30;
        }
        else 
        {
            needMoreScore.SetActive(true);
        }

    }

    public void SkinPolloViola()
    {
        int m_MaxScore = PlayerPrefs.GetInt("MaxScore", 0);
        if (m_MaxScore >= 60)
        {
            redSkin = true;
            m_MaxScore -= 60;
        }
        else
        {
            needMoreScore.SetActive(true);
        }


    }
    public void SkinPinguino()
    {
        int m_scoreCoins = PlayerPrefs.GetInt("coin", 0);
        if (m_scoreCoins >= 25)
        {
            pinguinoSkin = true;
            m_maxScore -= 25;
        }
        else
        {
            needMoreScore.SetActive(true);
        }

    }

    public void SkinRhino()
    {
        int m_scoreCoins = PlayerPrefs.GetInt("coin", 0);
        if (m_scoreCoins >= 30)
        {
            rhinoSkin = true;
            m_maxScore -= 30;
        }
        else
        {
            needMoreScore.SetActive(true);
        }

    }
    public void SkinPerry()
    {
        int m_scoreCoins = PlayerPrefs.GetInt("coin", 0);
        if (m_scoreCoins >= 60)
        {
            perrySkin = true;
            m_maxScore -= 60;
        }
        else
        {
            needMoreScore.SetActive(true);
        }

    }


}
