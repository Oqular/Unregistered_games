using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void StartGame()
    {
        PlayerPrefs.SetInt("roomCount", 0);
        PlayerPrefs.SetInt("goldCount", 0);
        PlayerPrefs.SetInt("playerHp", 3);
        SceneManager.LoadScene("main");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT GAME");
        Application.Quit();
    }


}
