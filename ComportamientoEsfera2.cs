using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoEsfera2 : MonoBehaviour
{
    public Llamada llamada;
    public GameObject targetType1; // La esfera de tipo 2 que es el objetivo para las esferas tipo 1
    public float moveSpeed = 3f;

    void Start()
    {
        // Suscribir al evento del cilindro
        llamada.OnCubeCollision += HandleCollisionWithCylinder;
    }
    void HandleCollisionWithCylinder()
    {
        // Si es tipo 1, moverse hacia la esfera de tipo 2
        Vector3 direction = (targetType1.transform.position - transform.position).normalized;
        transform.position += direction * moveSpeed * Time.deltaTime;
    }
}