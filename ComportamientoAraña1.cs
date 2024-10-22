using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ComportamientoAraña1 : MonoBehaviour
{
    public LlamadaArañas llamadaArañas;
    public GameObject[] spidersType1;   // Referencia al grupo de arañas tipo 1
    public GameObject[] Eggstarget; // El objeto hacia el que se moverán las arañas de tipo 1 cuando sea necesario
    public float moveSpeed = 5f;        // Velocidad de movimiento de las arañas
    private System.Random random;
    private Dictionary<GameObject, GameObject> spiderTargets; // Diccionario para almacenar el objetivo de cada araña

    void Start()
    {
        llamadaArañas.OnSpiderCollision1 += HandleCollisionWithType1;
        random = new System.Random();
        spiderTargets = new Dictionary<GameObject, GameObject>();
    }

    void HandleCollisionWithType1()
    {
        foreach (GameObject spider in spidersType1)
        {
            if (!spiderTargets.ContainsKey(spider))
            {
                GameObject randomEgg = Eggstarget[random.Next(0, Eggstarget.Length)];
                spiderTargets[spider] = randomEgg;
            }
        }
    }

    void Update()
    {
        foreach (GameObject spider in spidersType1)
        {
            if (spiderTargets.ContainsKey(spider))
            {
                GameObject targetEgg = spiderTargets[spider];
                Vector3 direction = (targetEgg.transform.position - spider.transform.position).normalized;
                
                // Verifica si la distancia es mayor que un pequeño umbral
                if (Vector3.Distance(spider.transform.position, targetEgg.transform.position) > 1f)
                {
                    spider.transform.position += direction * moveSpeed * Time.deltaTime;
                }
                else
                {
                    spider.transform.Find("Spider_Fuga_Red").gameObject.transform.GetComponent<Renderer>().material.color = Color.yellow;
                }
            }
        }
    }
}