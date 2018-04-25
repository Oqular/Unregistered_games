using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed;
    public float lifeTime;
    public int damage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        lifeTime -= Time.deltaTime;
        if(lifeTime <= 0)
        {
            Destroy(gameObject);
        }
	}

    public void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "Wall")
        {
            Debug.Log("hit a wall");
            Destroy(gameObject);
            
        }
        else if (collision.collider.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Enemy>().EnemyDamaged(damage);
            Destroy(gameObject);
        }
    }
}
