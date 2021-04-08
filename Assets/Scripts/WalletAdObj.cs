using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WalletAdObj : MonoBehaviour
{

public Text Text;
private float time;
	void OnEnable()
	{
		Text.text = "+"+(int)Score_manager.score/10;
		time = 0;
	}
}
