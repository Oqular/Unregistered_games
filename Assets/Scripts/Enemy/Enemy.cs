using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public bool alive;
    private float timerAfterDMG = 3;
    private float timer = 0;
    

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
        if (FindObjectOfType<PlayerController>().isInvulnerable)
        {
            TimerAfterDMG(timerAfterDMG);
        }
	}

    public void OnCollisionStay(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            if (!FindObjectOfType<PlayerController>().isInvulnerable)
            {
                FindObjectOfType<PlayerController>().isInvulnerable = true;
                FindObjectOfType<Character>().TakeDamage();
            }

        }
    }

    private void TimerAfterDMG(float timeAfterDMG)
    {
        timer += Time.deltaTime;
        if(timer >= timerAfterDMG)
        {
            timer = 0;
            FindObjectOfType<PlayerController>().isInvulnerable = false;
        }
    }

}
