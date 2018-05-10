using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour {

    public Sprite[] lives;
    public Image livesUI;
    public GameObject player;
    Character cha;

    void Start () {
        cha = player.GetComponent<Character>();
        cha.lives = FindObjectOfType<GameManager>().LoadPlayerHP();
	}
	
	void Update () {
        if (cha.lives <= 3 && cha.lives >= 0)
        {
            livesUI.sprite = lives[cha.lives];
        }
	}
}
