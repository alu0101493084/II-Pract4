using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoEsfera1 : MonoBehaviour
{
    public Llamada llamada;
    private GameObject cylinderTarget; // El cilindro hacia donde las esferas de tipo 2 se moverán
    public float moveSpeed = 3f;

    void Start()
    {
        cylinderTarget = GameObject.FindWithTag("Cilindro");
        // Suscribir al evento del cilindro
        llamada.OnCubeCollision += HandleCollisionWithCylinder;
    }
    void HandleCollisionWithCylinder()
    {
        // Si es tipo 2, moverse hacia el cilindro
        Vector3 direction = (cylinderTarget.transform.position - transform.position).normalized;
        transform.position += direction * moveSpeed * Time.deltaTime;
    }
}
