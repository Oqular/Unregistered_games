﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject inventoryButton;
    public GameObject pauseButton;
    public GameObject player;
    public GameObject statusCanvas;
    
	
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
        statusCanvas.SetActive(true);
        pauseButton.SetActive(true);
        inventoryButton.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        (player.GetComponent("PlayerController") as MonoBehaviour).enabled = false;
        pauseButton.SetActive(false);
        inventoryButton.SetActive(false);
        pauseMenuUI.SetActive(true);
        statusCanvas.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void BackToMenuLevel()
    {
        SceneManager.LoadScene("menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
