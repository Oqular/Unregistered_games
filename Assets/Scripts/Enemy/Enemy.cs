using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public bool alive;
    public int health;
    private int currentHealth;
    private float timerAfterDMG = 3;
    private float timer = 0;

    public GameObject goldPrefab;
    

	// Use this for initialization
	void Start () {
        alive = true;
        currentHealth = health;
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
        if(currentHealth <= 0)
        {
            Destroy(gameObject);
            alive = false;
            DropCoins();
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

    public void EnemyDamaged(int damage)
    {
        currentHealth -= damage;
        Debug.Log("current health is " + currentHealth);
    }

    public void DropCoins()
    {
        //GameObject coins = (GameObject)Instantiate(goldPrefab, transform.position, transform.rotation);
        FindObjectOfType<GameManager>().DropGold(this);
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
