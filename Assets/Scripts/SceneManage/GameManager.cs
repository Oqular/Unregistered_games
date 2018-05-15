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

    //    Saves

    public int roomCount;
    public int goldCount;
    public int playerHp;

	// Use this for initialization
	void Start () {

        //PlayerPrefs.SetInt("roomCount", 0);
        //PlayerPrefs.SetInt("goldCount", 0);
        //PlayerPrefs.SetInt("playerHp", 3);

        enemyCount = FindObjectOfType<InstanciateEnemys>().enemies.Count;
        roomFinished = false;
        roomCount = PlayerPrefs.GetInt("roomCount");
        goldCount = PlayerPrefs.GetInt("goldCount");
        playerHp = PlayerPrefs.GetInt("playerHp");
        FindObjectOfType<CoinUI>().coins = goldCount;
        FindObjectOfType<Character>().lives = playerHp;
        FindObjectOfType<InstanciateEnemys>().roomCount = roomCount;
        Debug.Log("goldCount : " + playerHp);
        FindObjectOfType<InstanciateEnemys>().Spawnenemies();
    }
	
	// Update is called once per frame
	void Update () {
		if(enemyCount <= 0 && !roomFinished)
        {
            Destroy(door);
            DropReward();
            roomFinished = true;
            roomCount++;
            
            playerHp = FindObjectOfType<Character>().lives;
            
            //Debug.Log("Coins : " + goldCount);
        }
        Debug.Log("halabala : " + roomCount);
        FindObjectOfType<InstanciateEnemys>().roomCount = roomCount;
        goldCount = FindObjectOfType<CoinUI>().coins;
        
        PlayerPrefs.SetInt("roomCount", roomCount);
        PlayerPrefs.SetInt("goldCount", goldCount);
        PlayerPrefs.SetInt("playerHp", playerHp);

        if (FindObjectOfType<Character>().lives <= 0)
            PlayerDied();

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

    public void PlayerDied()
    {
        Application.LoadLevel(0);
    }

}
