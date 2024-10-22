using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCubo : MonoBehaviour
{
    public float moveForce = 10f;  // Fuerza aplicada para mover el cubo
    public float maxVelocity = 5f; // Velocidad máxima del cubo
    private Rigidbody rb;

    void Start()
    {
        // Obtener el componente Rigidbody
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Recoger las entradas del jugador
        float moveX = Input.GetAxis("Horizontal"); // Movimiento en el eje X (A, D)
        float moveZ = Input.GetAxis("Vertical");   // Movimiento en el eje Z (W, S)

        // Crear un vector de movimiento basado en las entradas
        Vector3 movement = new Vector3(moveX, 0, moveZ);

        // Limitar la velocidad máxima para evitar que el cubo se mueva demasiado rápido
        if (rb.velocity.magnitude < maxVelocity)
        {
            // Aplicar una fuerza al cubo en la dirección del movimiento
            rb.AddForce(movement * moveForce);
        }
    }
}
