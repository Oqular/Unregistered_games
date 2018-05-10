﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciateEnemys : MonoBehaviour {

    public GameObject enemy;
    public List<GameObject> enemies;
    public Transform[] enemyPositions;
    public GameObject Boss;


	// Use this for initialization
	void Start () {
        int roomCount = GameObject.FindObjectOfType<GameManager>().LoadRoomCount();

        if (roomCount % 3 == 0)
        {
            enemies.Add(Instantiate(Boss, enemyPositions[0].transform.position, Quaternion.identity));
        }
        else
        {
            int count = Random.Range(3, 10);
            for (int i = 0; i < count; i++)
            {
                enemies.Add(Instantiate(enemy, enemyPositions[i].transform.position, Quaternion.identity));
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
