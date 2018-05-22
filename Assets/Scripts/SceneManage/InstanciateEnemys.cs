using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciateEnemys : MonoBehaviour {

    public GameObject enemy;
    public List<GameObject> enemies;
    public Transform[] enemyPositions;
    public GameObject Boss;

    public int roomCount;
    public int count;

    // Use this for initialization
    void Start () {
        //int roomCount = PlayerPrefs.GetInt("roomCount");
        Debug.Log("Enemies : " + roomCount);
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Spawnenemies()
    {
        if (roomCount % 3 == 2)
        {
            count = 1;
            enemies.Add(Instantiate(Boss, enemyPositions[0].transform.position, Quaternion.identity));
        }
        else
        {
            count = Random.Range(3, 10);
            for (int i = 0; i < count; i++)
            {
                enemies.Add(Instantiate(enemy, enemyPositions[i].transform.position, Quaternion.identity));
            }
        }
    }
}
