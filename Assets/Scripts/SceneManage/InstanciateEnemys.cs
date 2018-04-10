using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciateEnemys : MonoBehaviour {

    public GameObject[] enemies;
    public Transform[] enemyPositions;

	// Use this for initialization
	void Start () {
		for(int i = 0; i < enemies.Length; i++)
        {
            Instantiate(enemies[i], enemyPositions[i].transform.position, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
