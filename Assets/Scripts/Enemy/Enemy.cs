using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public bool alive;
    

	// Use this for initialization
	void Start () {
        alive = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (!alive)
        {
            FindObjectOfType<GameManager>().DropGold(this);
            Destroy(this.gameObject);
        }
	}

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            FindObjectOfType<Character>().TakeDamage();
        }
    }

}
