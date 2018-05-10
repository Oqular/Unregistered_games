using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InventoryMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject inventoryMenuUI;
    public GameObject inventoryButton;
    public GameObject pauseButton;
    public GameObject player;
    public GameObject statusCanvas;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                InventoryPause();
            }
        }
    }

    public void Resume()
    {
        //GameObject.find("Player").GetComponent<PlayerController>().enabled = false;
        (player.GetComponent("PlayerController") as MonoBehaviour).enabled = true;
        inventoryMenuUI.SetActive(false);
        statusCanvas.SetActive(true);
        inventoryButton.SetActive(true);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void InventoryPause()
    {
        (player.GetComponent("PlayerController") as MonoBehaviour).enabled = false;
        inventoryButton.SetActive(false);
        pauseButton.SetActive(false);
        statusCanvas.SetActive(false);
        inventoryMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
