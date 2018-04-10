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
	}
	
	void Update () {
        livesUI.sprite = lives[cha.lives];
	}
}
