using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Llamada : MonoBehaviour
{
    // Evento que las esferas escucharán
    public delegate void Message();
    public event Message OnCubeCollision;
    private void OnTriggerStay(Collider other)
    {
        // Detectar si el objeto que colisiona es el Cubo
        if (other.gameObject.CompareTag("Cubo"))
        {
            // Enviar el evento cuando el cubo colisiona con el cilindro
            OnCubeCollision();
        }
    }
}
