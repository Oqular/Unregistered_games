using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject gold;
    [SerializeField]
    private int enemyCount;
    public GameObject door;
    public GameObject reward;
    private bool roomFinished;
    private int roomCount;

    // Player Stats
    private int PlayerHP;
    private int PlayerGold;

	// Use this for initialization
	void Start () {
        //PlayerPrefs.SetInt("RoomCount", 0);

        enemyCount = FindObjectOfType<InstanciateEnemys>().enemies.Count;
        roomFinished = false;
        roomCount = 0;
        PlayerGold = 0;
        PlayerHP = 0;

        roomCount = LoadRoomCount();
        PlayerHP = LoadPlayerHP();
        PlayerGold = LoadPlayerGold();
        if (roomCount == 0)
        {
            PlayerPrefs.SetInt("RoomCount", 0);
            PlayerPrefs.SetInt("PlayerHP", 3);
            PlayerPrefs.SetInt("PlayerGold", 0);
        }

        //FindObjectOfType<CoinUI>().coins = LoadPlayerGold();
        //FindObjectOfType<Character>().lives = LoadPlayerHP();

        Debug.Log("RoomCount : " + roomCount);
        Debug.Log("Player HP : " + PlayerHP);
        Debug.Log("PlayerGold : " + PlayerGold);

    }
	
	// Update is called once per frame
	void Update () {
		if(enemyCount <= 0 && !roomFinished)
        {
            Destroy(door);
            DropReward();
            roomFinished = true;

            roomCount++;
            saveGame();

        }

        if(FindObjectOfType<Character>().lives <= 0)
        {
            PlayerPrefs.SetInt("RoomCount", 0);

            Application.LoadLevel(0);
        }

	}

    public void DropGold(Enemy enemy)
    {
        Instantiate(gold, enemy.transform.position, Quaternion.identity);
        enemyCount--;
    }

    public void DropReward()
    {
        Instantiate(reward, reward.transform.position, Quaternion.identity);
    }

    public void saveGame()
    {
        PlayerPrefs.SetInt("RoomCount", roomCount);
        PlayerPrefs.SetInt("PlayerHP", PlayerHP);
        PlayerPrefs.SetInt("PlayerGold", PlayerGold);
    }

    public int LoadRoomCount()
    {
        roomCount = PlayerPrefs.GetInt("RoomCount");

        return roomCount;
    }
    public int LoadPlayerHP()
    {
        PlayerHP = PlayerPrefs.GetInt("PlayerHP");

        return PlayerHP;
    }
    public int LoadPlayerGold()
    {
        PlayerGold = PlayerPrefs.GetInt("PlayerGold");

        return PlayerGold;
    }



}
