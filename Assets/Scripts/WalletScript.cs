using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalletScript : MonoBehaviour {
	public static int Wallet {get; private set;}

	void Start () 
	{
		if(!PlayerPrefs.HasKey("Coins"))
			PlayerPrefs.SetInt("Coins", 123000);
			Wallet = PlayerPrefs.GetInt("Coins");
	}
	
	void Update () 
	{
		
	}
}
