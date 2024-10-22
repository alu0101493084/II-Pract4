using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlamadaArañas : MonoBehaviour
{
    public delegate void Message();
    public delegate void Message2(GameObject egg);
    public event Message OnSpiderCollision1;
    public event Message OnSpiderCollision2;
    public event Message2 OnEggCollision1;
    public event Message2 OnEggCollision2;
    private bool isColliding1 = false;
    private bool isColliding2 = false;
    void Update ()
    {
        if (isColliding1)
        {
            OnSpiderCollision1();
        }
        else if (isColliding2)
        {
            OnSpiderCollision2();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Tipo 2"))
        {
            isColliding2 = true;
        }
        else if (collision.gameObject.CompareTag("Tipo 1"))
        {
            isColliding1 = true;
        }
        else if (collision.gameObject.CompareTag("Huevo T1"))
        {
            OnEggCollision1(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Huevo T2"))
        {
            OnEggCollision2(collision.gameObject);
        }
    }
}
