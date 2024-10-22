using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransporte : MonoBehaviour
{
    public GameObject[] arañas1;   // Referencia al grupo de teletransporte
    public GameObject[] arañas2;
    public GameObject target;
    public float distance;
    private GameObject Cubo;
    void Start()
    {
        Cubo = GameObject.FindWithTag("Cubo");
    }
    void Update()
    {
        if ((transform.position - Cubo.transform.position).magnitude <= distance)
        {
            foreach (GameObject araña1 in arañas1)
            {
                araña1.transform.position = target.transform.position;
            }
            foreach (GameObject araña2 in arañas2)
            {
                araña2.transform.LookAt(transform.position);
            }
        }
    }
}
