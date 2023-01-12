using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScriptArbol : MonoBehaviour
{    
    [SerializeField]
    TMP_Text puntuaje;
    [SerializeField]
    GameObject p1, p2, p3, p4, restart;
    //float p1contador = 0, p2contador = 0, p3contador = 0, p4contador = 0;
    Vector3 posInicial = new Vector3(0,0,-2.5f);
    private void Update()
    {
        puntuaje.text = ("Puntos de amor: " + Amor);
        if (_amor == 0)
        {
            restart.gameObject.SetActive(true);
        }
    }

    private static ScriptArbol _instance;
    public static ScriptArbol Instance { get { return _instance; } }

    private float _amor = 1;
    public float Amor { get { return _amor; } }
    private void Awake()
    {
        _amor = PlayerPrefs.GetFloat("puntos", _amor);
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public void SumarPuntosAmor(float amount)
    {
        _amor += amount;
        Evolución();
        PlayerPrefs.SetFloat("puntos", _amor);
    }

    public void Restart()
    {
        Alimentacion.x = 1;
        PlayerPrefs.DeleteAll();
        restart.gameObject.SetActive(false);
        p1.gameObject.SetActive(true);
        p2.gameObject.SetActive(true);
        p3.gameObject.SetActive(true);
        p4.gameObject.SetActive(true);
        _amor = 1;
        p1.transform.position = new Vector3(0, 0, -2.5f);
        p1.transform.localScale = new Vector3(1, 1, 1);
        p2.transform.localScale = new Vector3(1, 1, 1);
        p3.transform.localScale = new Vector3(1, 1, 1);
        p4.transform.localScale = new Vector3(1, 1, 1);
    }


    //----------------------------------EVOLUCIÓN---------------------------------------
    private void Start()
    {
        if (Amor <= 0)
        {
            p1.gameObject.SetActive(false);
            p2.gameObject.SetActive(false);
            p3.gameObject.SetActive(false);
            p4.gameObject.SetActive(false);
            //reset.gameObject.SetActive(True);
        }
        if (Amor <= 5 && Amor >= 1 /*&& p1contador != 1*/)
        {
            /*Instantiate(p1, new Vector3(0, 0, -2.5f), new Quaternion(0f, 180f, 0f, 0f));
            Destroy(p2.gameObject);
            p1contador = 1;
            p2contador = 0;^*/
            p1.transform.position = new Vector3(0, 0, -2.5f);
            p2.transform.position = new Vector3(2, 0, 2);
            p3.transform.position = new Vector3(3, 0, 2);
            p4.transform.position = new Vector3(4, 0, 2);
        }
        if (Amor <= 20 && Amor >= 6)
        {
            /*p1contador = 0;
            p2contador = 1;
            Instantiate(p2, new Vector3(0, 1, -2.5f), new Quaternion(0f, 0f, 90f, 0f));
            Destroy(p1.gameObject);*/
            p2.transform.position = new Vector3(0, 0, -2.5f);
            p1.transform.position = new Vector3(1, 0, 2);
            p3.transform.position = new Vector3(3, 0, 2);
            p4.transform.position = new Vector3(4, 0, 2);
        }
        if (Amor <= 60 && Amor >= 21)
        {
            p3.transform.position = new Vector3(0, 0, -2.5f);
            p1.transform.position = new Vector3(1, 0, 2);
            p2.transform.position = new Vector3(2, 0, 2);
            p4.transform.position = new Vector3(4, 0, 2);
        }
        if (Amor <= 100 && Amor >= 61)
        {
            p4.transform.position = new Vector3(0, 0, -2.5f);
            p1.transform.position = new Vector3(1, 0, 2);
            p2.transform.position = new Vector3(2, 0, 2);
            p3.transform.position = new Vector3(3, 0, 2);
        }
    }
    void Evolución()
    {
        if (Amor <= 0)
        {
            p1.gameObject.SetActive(false);
            p2.gameObject.SetActive(false);
            p3.gameObject.SetActive(false);
            p4.gameObject.SetActive(false);
            //reset.gameObject.SetActive(True);
        }
        if (Amor <= 5 && Amor >= 1)
        {
            p1.transform.position = new Vector3(0,0,-2.5f);
            p2.transform.position = new Vector3(2, 0, 2);
            p3.transform.position = new Vector3(3, 0, 2);
            p4.transform.position = new Vector3(4, 0, 2);
        }
        if (Amor <= 20 && Amor >= 6)
        {
            p2.transform.position = new Vector3(0, 0, -2.5f);
            p1.transform.position = new Vector3(1, 0, 2);
            p3.transform.position = new Vector3(3, 0, 2);
            p4.transform.position = new Vector3(4, 0, 2);
        }
        if (Amor <= 60 && Amor >= 21)
        {
            p3.transform.position = new Vector3(0, 0, -2.5f);
            p1.transform.position = new Vector3(1, 0, 2);
            p2.transform.position = new Vector3(2, 0, 2);
            p4.transform.position = new Vector3(4, 0, 2);
        }
        if (Amor <= 100 && Amor >= 61)
        {
            p4.transform.position = new Vector3(0, 0, -2.5f);
            p1.transform.position = new Vector3(1, 0, 2);
            p2.transform.position = new Vector3(2, 0, 2);
            p3.transform.position = new Vector3(3, 0, 2);
        }
    }
}
