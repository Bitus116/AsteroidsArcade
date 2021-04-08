//it`s on canvas
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class Player_respawn : MonoBehaviour
{
    public GameObject Respawn_Button;//button
    public GameObject respwnpoint;//point whaere the player respawn
    public GameObject Player;// player variable
    public GameObject MovingZone;
    public GameObject Text;
    public static bool isrespawning = true;//true when button click
    public static float timefromrespawn;//0 when button click
    private GameObject clone;// respawned player
    public static bool isgamerunning = false;
    public GameObject WalletADobj;

    void Update()
    {
        if (Asteroid_action.isPlayer)//if player is die button activating
        {
            float time = Time.time;
            Text.SetActive(false);
            MovingZone.SetActive(false);
            Respawn_Button.SetActive(true);
            Asteroid_action.isPlayer = false;
            isgamerunning = false;
            Invoke("showad", 0.5f);
            WalletADobj.SetActive(true);
        }
        timefromrespawn += Time.deltaTime;
        if (timefromrespawn >= 3 && isrespawning)// player can shoot when 3 seconds had not passed
        {
            while(clone == null)
                clone = GameObject.FindGameObjectWithTag("Player");
            Laser_spawner other = clone.GetComponent<Laser_spawner>();
            other.enabled = true;
            isrespawning = false;
        }


    }
    public void OnRespawnButtonClick()
    {
        Text.SetActive(true);
        Score_manager.score = 0;
        Asteroid_action.IsMeteor = true;
        MovingZone.SetActive(true);
        Invoke("restart", 0);// call respawn 
        timefromrespawn = 0;// change time fron respawn to 0
        Respawn_Button.SetActive(false);//deactivating button
        isrespawning = true;//player respawning
    }
    void restart()
    {
        Asteroid_Sp.speed = 0;// change speed to Initial value
        clone = Instantiate(Player, respwnpoint.transform);// spawn player
        Laser_spawner other = clone.GetComponent<Laser_spawner>();//player can`t shoot for 3 seconds
        other.enabled = false;//player can`t shoot for 3 seconds
        isgamerunning = true;
    }
    public void Exit()
    {
        Application.Quit();
    }
    void showad()
    {
        if (Advertisement.IsReady())
            Advertisement.Show();
    }
}
