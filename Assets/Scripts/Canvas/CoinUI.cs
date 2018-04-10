using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinUI : MonoBehaviour {

    public int coins;
    private Text txt;

    private void Awake()
    {
        coins = 0;
        txt = GetComponent<Text>();
    }

    void Update () {
        txt.text = "Coins x" + coins;
	}
}
