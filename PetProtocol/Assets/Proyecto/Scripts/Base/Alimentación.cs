using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alimentación : MonoBehaviour
{
    [SerializeField]
    GameObject pet, comida, nocomida, menu, alimentar;
    public float contador;

    private void Start()
    {
        menu.SetActive(true);
        alimentar.SetActive(false);
    }
    public void Alimentar()
    {
        contador = 30;
        menu.SetActive(false);
        alimentar.SetActive(true);
    }
    void Regreso()
    {
        menu.SetActive(true);
        alimentar.SetActive(false);
        contador = 0;
    }
    private void Update()
    {
        if (contador > 0)
        {
            contador = contador - 1 * Time.deltaTime;
        }

        if (contador < 0)
        {
            Regreso();
        }
        Debug.Log(contador);
    }
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
