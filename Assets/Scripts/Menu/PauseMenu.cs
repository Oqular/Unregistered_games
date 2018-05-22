using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject pauseButton;
    public GameObject player;
    public GameObject DeathUI;


    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
	}

    public void Resume()
    {
        //GameObject.find("Player").GetComponent<PlayerController>().enabled = false;
        (player.GetComponent("PlayerController") as MonoBehaviour).enabled = true;
        pauseMenuUI.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        (player.GetComponent("PlayerController") as MonoBehaviour).enabled = false;
        pauseButton.SetActive(false);
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Death()
    {
        
        (player.GetComponent("PlayerController") as MonoBehaviour).enabled = false;
        Time.timeScale = 0f;
        GameIsPaused = true;
        DeathUI.SetActive(true);

    }

    public void BackToMenuLevel()
    {
        //GameIsPaused = !GameIsPaused;
        //DeathUI.SetActive(false);
        //(player.GetComponent("PlayerController") as MonoBehaviour).enabled = true;
        //Time.timeScale = 1f;
        SceneManager.LoadScene("menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
