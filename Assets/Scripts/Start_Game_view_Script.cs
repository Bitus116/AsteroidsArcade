using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start_Game_view_Script : MonoBehaviour {

    public GameObject Start_Panel;
    public GameObject Game;
    public GameObject Score;
    public static bool IsGameRun = false;
    public Text Wallet;

    void Start()
    {
        Wallet.text ="" + WalletScript.Wallet;
    }

    public void OnPlayButtonClick()
    {   
        Player_respawn.isgamerunning = true;
        IsGameRun = true;
        Start_Panel.SetActive(false);
        Game.SetActive(true);
        Score.SetActive(true);
    }
}
