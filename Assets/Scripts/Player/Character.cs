using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    public int lives;
    
    // Use this for initialization
	void Start () {
        //lives = 3;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TakeDamage()
    {
        lives--;
    }

}
