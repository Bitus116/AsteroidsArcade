//this script swapn a meteors
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid_Sp : MonoBehaviour
{
    public GameObject[] meteors;//meteor prefab
    public GameObject sputnik;
    private int spawnpoint_index;// index of random spawnpoint
    public static float speed;//meteor speed
    public float SpawnRate = 1.2f;// spawn rate

    void Start()
    {
        StartCoroutine(Spawn()); //start spawn Enum
    }
    IEnumerator Spawn()
    {
        while (true)//endless cycle
        {
            if(Start_Game_view_Script.IsGameRun)
            {
            Debug.Log("meteor!!!");// massage in console
            spawnpoint_index = Random.Range(0, 17);// randomize spawnpoint
            int prev = spawnpoint_index;//previews spawnpoint
            while (prev == spawnpoint_index && prev - spawnpoint_index == 10)// if spawnpoint = prev spawnpoint it will be changed
            {
                spawnpoint_index = Random.Range(0, 17);//change spawnpoint
            }
            Vector3 spawnpos = new Vector3(Random.Range(29, 400), 660);
            int objectid = Random.Range(0 , 100);
            if(objectid < 33)
                Instantiate(meteors[0], spawnpos , Quaternion.identity);//spawn meteor
            else if(objectid > 32 && objectid < 65)
                Instantiate(meteors[1], spawnpos, Quaternion.identity);//spawn meteor
            else if(objectid > 65 && objectid < 97)
                Instantiate(meteors[2], spawnpos, Quaternion.identity);//spawn meteor
            else if(objectid > 97)
                Instantiate(sputnik, spawnpos, Quaternion.identity);//spawn sputnik - 1
            else
                Instantiate(meteors[1], spawnpos, Quaternion.identity);//spawn meteor
            speed += 1.3f;//meteor spedd Enlargement
            }
            yield return new WaitForSeconds(SpawnRate);//wait for spawn rate
        }
    }
}