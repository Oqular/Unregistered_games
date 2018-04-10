using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject gold;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DropGold(Enemy enemy)
    {
        Instantiate(gold, enemy.transform.position, Quaternion.identity);
    }

}
