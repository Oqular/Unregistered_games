using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinUI : MonoBehaviour {

    public int coins;
    private Text txt;

    private void Awake()
    {
        coins = FindObjectOfType<GameManager>().LoadPlayerGold() ;
        txt = GetComponent<Text>();
    }

    public void Start()
    {
        coins = FindObjectOfType<GameManager>().LoadPlayerGold();
    }

    void Update () {
        txt.text = "Coins x" + coins;
	}

    public void AddGold(int gold)
    {
        coins += gold;
    }
}
