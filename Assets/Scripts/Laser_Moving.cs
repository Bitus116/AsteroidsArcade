// this script on laser prefab and it`s move a laser

using UnityEngine;

public class Laser_Moving : MonoBehaviour
{

    public float speed;//laser speed(can change in inspector)

    void Update()
    {
        transform.position += new Vector3(0, speed * Time.deltaTime);//laser moving
        if (gameObject.transform.position.y > 720)//if laser flew so far(20 pixels) it will destroy
            Destroy(gameObject);
    }

}
