using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldPickUp : MonoBehaviour {

    public float radius;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance(FindObjectOfType<PlayerController>().transform.position, this.transform.position) <= radius)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, FindObjectOfType<PlayerController>().transform.position, 10 * Time.deltaTime);
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            FindObjectOfType<CoinUI>().AddGold(50);
            Destroy(this.gameObject);
        }
    }
}
