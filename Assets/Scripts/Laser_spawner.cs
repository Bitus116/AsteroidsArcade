//shooting script on player
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_spawner : MonoBehaviour
{
    public float SpawnRate;// laser spawnrate
    public GameObject laser;//laser prefab
    public GameObject[] Laser_spawnpoints;//laser spawnpoints(on guns)

    void Start()
    {
        StartCoroutine(SpawnLaser());//call spawn laser
    }
    IEnumerator SpawnLaser()
    {
        while (Player_respawn.isgamerunning && Start_Game_view_Script.IsGameRun)//if game running
        {
            Debug.Log("shoot");//debug massage
            Vector3 spawnpoint1 = Laser_spawnpoints[0].transform.position;//SP1 pos
            Vector3 spawnpoint2 = Laser_spawnpoints[1].transform.position;//SP2 pos
            Instantiate(laser, spawnpoint1, Quaternion.identity);//spawn first laser
            Instantiate(laser, spawnpoint2, Quaternion.identity);//second
            yield return new WaitForSeconds(SpawnRate);// wait for spawnrate
        }

    }
}
