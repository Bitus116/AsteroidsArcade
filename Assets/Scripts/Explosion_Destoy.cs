//it`s on exposions prefabs
using UnityEngine;

public class Explosion_Destoy: MonoBehaviour
{


    void Start()
    {
        if (Asteroid_action.isPlayer == true)  //Destroy player explosion in 0.32 seconds
        {
            Destroy(gameObject, 0.32f);
        }

        else              //Destroy meteor explosion in 1 second
        {
            Destroy(gameObject, 1f);
        }

    }
}
