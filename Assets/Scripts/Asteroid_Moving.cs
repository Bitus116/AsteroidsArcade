// script which move the meteors
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid_Moving : MonoBehaviour
{
    public float speed;//meteor speed

    void Start()
    {
        speed += Asteroid_Sp.speed;//Enlargement speed by speed from meteor spawner script
    }

    void Update()
    {
        transform.position -= new Vector3(0, speed * Time.deltaTime);//moving a meteors
        if (gameObject.transform.position.y < -20)//if meteor flew so far(20 pixels) it will destroy
            Destroy(gameObject);//destroymeteor
    }
}
