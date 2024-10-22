using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoleccion2 : MonoBehaviour
{
    public LlamadaArañas llamadaArañas;
    public GameObject eggType2;
    void Start()
    {
        llamadaArañas.OnEggCollision2 += HandleEggCollisionWithType2;
    }
    void HandleEggCollisionWithType2(GameObject collidedEgg)
    {   
        if (eggType2 == collidedEgg)
        {
            Destroy(eggType2);
            ScoreManager.score += 10;
            Debug.Log("Score: " + ScoreManager.score);
        }
    }
}
