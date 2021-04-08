//this script attached to meteor prefab and called when some object accross the meteor
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid_action : MonoBehaviour
{
    public GameObject boom;//explosion prefab
    public GameObject PlayerBoom;//player explosion prefab
    public static bool IsMeteor;

    public static bool isPlayer; //checks: is it player?
    void OnTriggerEnter2D(Collider2D other)//called when some objects accrosed with meteor
    {
        if (other.gameObject.tag == "Player")//checks: is it player?
        {
            if (Player_respawn.timefromrespawn > 3f)//if from respawn less then 3 seconds player will not die
            {
                Instantiate(PlayerBoom, other.transform.position, Quaternion.identity);//spawn player explosion prefab
                isPlayer = true;// player die
                Destroy(other.gameObject);// destroy player game object
                Player_respawn.isgamerunning = false; 
            }

        }
        if (other.gameObject.tag == "Laser")//do when it`s laser
        {
            Score_manager.score++;// +1 point
            Destroy(gameObject);//destroy laser
            Vector3 pos = gameObject.transform.position;//checks meteor position
            Instantiate(boom, pos, Quaternion.identity);//spawn expolosion
            Destroy(other.gameObject);//destroy meteor
            IsMeteor = true;
        }

    }

}
