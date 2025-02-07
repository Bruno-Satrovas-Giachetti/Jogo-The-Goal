using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    GameObject Pause_Screen;
    bool IsPaused;

    private void Start()
    {
        Pause_Screen = GameObject.Find("Pause_Screen");
        Pause_Screen.SetActive(false);
        IsPaused = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !IsPaused)
        {
            Pause();
        }

        else if (Input.GetKeyDown(KeyCode.Escape) && IsPaused)
        {
            Continue();
        }


    }

    public void Pause()
    {
        Pause_Screen.SetActive(true);
        Time.timeScale = 0;
        IsPaused = true;
    }

    public void Continue()
    {
        Pause_Screen.SetActive(false);
        Time.timeScale = 1;
        IsPaused = false;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
