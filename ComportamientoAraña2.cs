using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoAraña2 : MonoBehaviour
{
    public LlamadaArañas llamadaArañas;
    public GameObject[] spidersType1;   // Referencia al grupo de arañas tipo 1
    public GameObject target; // El objeto hacia el que se moverán las arañas de tipo 1 cuando sea necesario
    // Start is called before the first frame update
    public float moveSpeed = 5f;        // Velocidad de movimiento de las arañas
    void Start()
    {
        llamadaArañas.OnSpiderCollision2 += HandleCollisionWithType2;
    }

    // Update is called once per frame
    void HandleCollisionWithType2()
    {
        foreach (GameObject spider in spidersType1)
            {
                Vector3 direction = (target.transform.position - spider.transform.position).normalized;
                spider.transform.position += direction * moveSpeed * Time.deltaTime;
            }
    }
}