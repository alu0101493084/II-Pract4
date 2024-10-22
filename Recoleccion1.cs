using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoleccion1 : MonoBehaviour
{
    public LlamadaArañas llamadaArañas;
    public GameObject eggType1;
    void Start()
    {
        llamadaArañas.OnEggCollision1 += HandleEggCollisionWithType1;
    }
    void HandleEggCollisionWithType1(GameObject collidedEgg)
    {   
        if (eggType1 == collidedEgg)
        {
            Destroy(eggType1);
            ScoreManager.score += 5;
            Debug.Log("Score: " + ScoreManager.score);
        }
    }
}
