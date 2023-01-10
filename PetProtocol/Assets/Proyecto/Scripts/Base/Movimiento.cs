using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField]
    GameObject pet;
    float velocidad;
    
    public void Derecha()
    {
        pet.transform.position = (new Vector3 (1f, 0, 0) * velocidad);
    }

    public void Izquierda()
    {
        pet.transform.position = (new Vector3(-1f, 0, 0) * velocidad);
    }
}
