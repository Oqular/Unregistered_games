using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject gold;
    [SerializeField]
    private int enemyCount;
    public GameObject door;
    public GameObject reward;
    private GameObject[] enemies;
    //private bool roomFinished;

	// Use this for initialization
	void Start () {
        //enemyCount = FindObjectOfType<InstanciateEnemys>().enemies.Length;
        //roomFinished = false;
	}
	
	// Update is called once per frame
	void Update () {
        //enemies = GameObject.FindGameObjectsWithTag("Enemy");
        //enemyCount = enemies.Length;
        //Debug.Log(enemyCount);
    }

    public void DropGold(Enemy enemy)
    {
        Instantiate(gold, enemy.transform.position, Quaternion.identity);
    }

    public void DropReward()
    {
        Instantiate(reward, reward.transform.position, Quaternion.identity);
    }

}
