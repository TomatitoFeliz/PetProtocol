using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limpieza : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "comida")
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "nocomida")
        {
            Destroy(other.gameObject);
        }
    }
}
