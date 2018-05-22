using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinUI : MonoBehaviour {

    public int coins;
    private Text txt;

    public void Start()
    {
        txt = GetComponent<Text>();
    }

    void Update () {
        txt.text = "Coins x" + coins;
	}

    public void AddGold(int gold)
    {
        coins += gold;
    }
}
