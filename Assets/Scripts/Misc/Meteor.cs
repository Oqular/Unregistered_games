using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            FindObjectOfType<Character>().TakeDamage();
            Destroy(this.gameObject);
        }
        if (collision.collider.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
    }
}
