using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alimentacion : MonoBehaviour
{
    [SerializeField]
    GameObject p1, p2, p3, p4;
    float horaActual;
    float hora;
    float dentroDeTresHoras;
    float dentroDeVeinteMin;
    public float tresh = 10800f;
    public float veintem = 1200f;
    public static float x = 1;
    private void Awake()
    {
        dentroDeVeinteMin = PlayerPrefs.GetFloat("tiemporestarhambre", dentroDeVeinteMin);
        dentroDeTresHoras = PlayerPrefs.GetFloat("tiempohambre", dentroDeTresHoras);
    }
    void CalcularAccionDentroDeTresHoras()
    {
        horaActual = Time.time;
        dentroDeTresHoras = horaActual + tresh;
    }
    private void Start()
    {
        CalcularAccionDentroDeTresHoras();
        dentroDeVeinteMin = dentroDeTresHoras + veintem;
    }
    private void RestaPorHambre()
    {
        hora = Time.time;
        Debug.Log("Se muere de Hambre");
        ScriptArbol.Instance.SumarPuntosAmor(-0.25f);
        dentroDeVeinteMin = hora + veintem;
    }
    private void Update()
    {
        PlayerPrefs.SetFloat("tiemporestarhambre", dentroDeVeinteMin);
        PlayerPrefs.SetFloat("tiempohambre", dentroDeTresHoras);

        //Debug.Log(Time.time);
        if (Time.time >= dentroDeTresHoras)
        {
            Debug.Log("Tiene Hambre");
            //dentroDeVeinteMin = dentroDeTresHoras + veintem;
            if (Time.time >= dentroDeVeinteMin)
            {
                RestaPorHambre();
            }
            if (Respawn.comidan == 4 && Respawn.nocomidan == 3)
            {
                horaActual = Time.time;
                dentroDeTresHoras = horaActual + tresh;
                Debug.Log("Ya no tiene Hambre");
            }
        }
    }
    private void PuntosPorHambreComida()
    {
        if (Time.time >= dentroDeTresHoras)
        {
            Debug.Log("Comió");
            ScriptArbol.Instance.SumarPuntosAmor(3);
        }
        else
        {
            x++;
            p1.transform.localScale = new Vector3(x, 1, 1);
            p2.transform.localScale = new Vector3(x, 1, 1);
            p3.transform.localScale = new Vector3(x, 1, 1);
            p4.transform.localScale = new Vector3(x, 1, 1);
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
