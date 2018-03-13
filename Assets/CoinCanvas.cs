using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCanvas : MonoBehaviour {

	public int coins = 0;
	private Text txt;

	void Awake (){
		txt = GetComponent<Text> ();
	}

	void Update () {
		txt.text = "Coins x" + coins;
	}
}
