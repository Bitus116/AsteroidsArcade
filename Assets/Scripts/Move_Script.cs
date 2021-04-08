//it`s on movingzone on scene
using UnityEngine;

public class Move_Script : MonoBehaviour
{

    public Transform Player;//player variable
    private GameObject pl;// variable for player initialization
    public float speed = 10f;//motion speed

    void OnMouseDrag()
    {
        if (Player_respawn.isgamerunning) // if game is running you can move 
        {
            if (Player_respawn.isrespawning)
            {
                pl = GameObject.FindWithTag("Player");  //find player
                Player = pl.transform; //initialization Player GameObject
            }
            Vector3 pos; //Position variable
            pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//initialization Position variable
            if (pos.x < 2f)//player can`t move less then 2 pixels
                pos.x = 2f;
            if (pos.x > 420f)//player can`t move more then 420 pixels
                pos.x = 420f;
            Player.position = Vector2.MoveTowards(Player.position, new Vector2(pos.x, Player.position.y), speed * Time.deltaTime); //smooth player motion with some speed
        }
    }
}
