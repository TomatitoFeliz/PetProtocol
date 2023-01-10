using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alimentacion : MonoBehaviour
{
    [SerializeField]
    GameObject p1, p2, p3, p4;
    float horaActual;
    float dentroDeTresHoras;
    float dentroDeVeinteMin;
    public float tresh = 10;
    public float veintem = 10;
    void CalcularAccionDentroDeTresHoras()
    {
        horaActual = Time.time;
        dentroDeTresHoras = horaActual + tresh;
    }
    private void Start()
    {
        CalcularAccionDentroDeTresHoras();
    }
    private void Update()
    {
        Debug.Log(Time.time);
        if (Time.time >= dentroDeTresHoras)
        {
            Debug.Log("Tres Horas");
            dentroDeVeinteMin = dentroDeTresHoras + veintem;
            if (Time.time >= dentroDeVeinteMin)
            {
                ScriptArbol.Instance.SumarPuntosAmor(-1);
                Debug.Log("20 Minutos");
            }

        }
    }
    private void PuntosPorHambreComida()
    {
        if (Time.time >= dentroDeTresHoras)
        {
            Debug.Log("Tiene Hambre");
            ScriptArbol.Instance.SumarPuntosAmor(3);
        }
        else
        {
            p1.transform.localScale = new Vector3(1, 0, 0);
            p2.transform.localScale = new Vector3(1, 0, 0);
            p3.transform.localScale = new Vector3(1, 0, 0);
            p4.transform.localScale = new Vector3(1, 0, 0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "comida")
        {
            PuntosPorHambreComida();
        }
        if (other.tag == "nocomida")
        {
            ScriptArbol.Instance.SumarPuntosAmor(-1);
        }
    }

}
