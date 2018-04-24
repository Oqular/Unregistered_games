using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}

    public void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "Wall")
        {
            Debug.Log("Wall");
            
        }
    }
}
