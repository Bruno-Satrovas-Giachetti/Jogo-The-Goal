using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelButton : MonoBehaviour
{
    GameObject MusicMan;

    private void Start()
    {
        MusicMan = GameObject.Find("MusicMan");
    }

    public void LoadMainMenu()
    {
        KeepValues.Values.ResetGame();
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadOpening1()
    {
        SceneManager.LoadScene("Opening1");
    }
    
    public void LoadOpening2()
    {
        SceneManager.LoadScene("Opening2");
    }

    public void LoadOpening3()
    {
        SceneManager.LoadScene("Opening3");
    }

    public void LoadTutorial()
    {
        Destroy(MusicMan);
        SceneManager.LoadScene("Tutorial");
    }

    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }

    public void LoadLevel2_1()
    {
        SceneManager.LoadScene("Level2_1");
    }

    public void LoadLevel2_2()
    {
        SceneManager.LoadScene("Level2_2");
    }

    public void LoadLevel2_3()
    {
        SceneManager.LoadScene("Level2_3");
    }

    public void LoadLevel2_4()
    {
        SceneManager.LoadScene("Level2_4");
    }

    public void LoadLevel2_5()
    {
        SceneManager.LoadScene("Level2_5");
    }

    public void LoadLevel3_1()
    {
        SceneManager.LoadScene("Level3_1");
    }

    public void LoadLevel3_2()
    {
        SceneManager.LoadScene("Level3_2");
    }

    public void LoadLevel3_3()
    {
        SceneManager.LoadScene("Level3_3");
    }
    public void LoadLevel3_4()
    {
        SceneManager.LoadScene("Level3_4");
    }
    public void LoadLevel3_5()
    {
        SceneManager.LoadScene("Level3_5");
    }

    public void LoadLevel3_6()
    {
        SceneManager.LoadScene("Level3_6");
    }

    public void LoadLevel3_7()
    {
        SceneManager.LoadScene("Level3_7");
    }

    public void LoadLevel3_8()
    {
        SceneManager.LoadScene("Level3_8");
    }

    public void LoadLevel3_9()
    {
        SceneManager.LoadScene("Level3_9");
    }

    public void LoadLevel3_10()
    {
        SceneManager.LoadScene("Level3_10");
    }

    public void LoadLevel4()
    {
        SceneManager.LoadScene("Level4");
    }

    public void LoadScorePage()
    {
        SceneManager.LoadScene("ScorePage");
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void LoadMichael()
    {
        SceneManager.LoadScene("MichaelLevel");
    }
}
