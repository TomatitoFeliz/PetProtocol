using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alimentación : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "comida")
        {
            other.gameObject.SetActive(false);
            //amor = amor + 3;
        }
        else if (other.tag == "nocomida")
        {
            other.gameObject.SetActive(false);
            //amor = amor - 1;
        }
    }
}
