using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPrincipal : MonoBehaviour
{

    [SerializeField]
    GameObject pet, comida, nocomida, menu, alimentar;
    public int amor = 1;
    public float contador;

    void Start()
    {
        menu.SetActive(true);
        alimentar.SetActive(false);
        amor = Mathf.Clamp(amor, 0, 100);

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
        //Suma de puntos de amor en base a la alimentación:
    private void OnTriggerEnter(Collider other)
    {
        
    }

}

