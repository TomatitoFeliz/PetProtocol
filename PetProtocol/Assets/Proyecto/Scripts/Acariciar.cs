using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acariciar : MonoBehaviour
{
    [SerializeField]
    GameObject particulas;
    //float contador = 2;
    float horaActual;
    float cadaDosHoras;
    float cada24Horas;
    float cada30min;
    public float tMin = 1800;
    public float vcHoras = 86400;
    public float dosHoras = 7200;
    float repetirmin;
    private void Awake()
    {
        cada24Horas = PlayerPrefs.GetFloat("tiempoparacaricia", cada24Horas);
        cada30min = PlayerPrefs.GetFloat("tiemporestacaricia", cada30min);
        cadaDosHoras = PlayerPrefs.GetFloat("tiempopuntoscaricia", cadaDosHoras);
    }
    private void Start()
    {
        horaActual = Time.time;
        cadaDosHoras = horaActual + dosHoras;
        cada24Horas = horaActual + vcHoras;
        cada30min = cada24Horas + tMin;
    }
    /*public void Contador()
    {
        if (contador >= 0)
        {

            contador -= Time.deltaTime;
        }
    }*/
    private void Update()
    {
        PlayerPrefs.SetFloat("tiempoparacaricia", cada24Horas);
        PlayerPrefs.SetFloat("tiemporestacaricia", cada30min);
        PlayerPrefs.SetFloat("tiempopuntoscaricia", cadaDosHoras);
        Debug.Log(Time.time);
        if (Input.GetMouseButtonDown(0))
        {
            //Invoke("Contador", 0);
            Vector3 pos = Input.mousePosition;
            Ray rayo = Camera.main.ScreenPointToRay(pos);
            RaycastHit hitinfo;
            if (Physics.Raycast(rayo, out hitinfo) == true /*&& contador <= 0*/)
            {
                if (hitinfo.collider.tag.Equals("Slime"))
                {
                    if (Time.time >= cadaDosHoras)
                    {
                        horaActual = Time.time;
                        ScriptArbol.Instance.SumarPuntosAmor(10);
                        cadaDosHoras = cadaDosHoras + dosHoras;
                        cada24Horas = horaActual + vcHoras;
                    }
                    Instantiate(particulas, new Vector3(0, 1, -2.5f), Quaternion.identity);
                    //contador = 2;
                }
            }
        }
        else if (Time.time >= cada24Horas)
        {
            if (Time.time >= cada30min)
            {
                repetirmin = Time.time;
                ScriptArbol.Instance.SumarPuntosAmor(-1);
                cada30min = repetirmin + tMin;
            }
        }
    }
}
