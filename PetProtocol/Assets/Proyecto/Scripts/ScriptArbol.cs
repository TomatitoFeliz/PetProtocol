using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptArbol : MonoBehaviour
{
    [SerializeField]
    GameObject p1, p2, p3, p4;
    Vector3 posInicial = new Vector3(0,0,-2.5f);

    private static ScriptArbol _instance;
    public static ScriptArbol Instance { get { return _instance; } }

    private float _amor = 1;
    public float Amor { get { return _amor; } }
    private void Awake()
    {
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
        if (Amor <= 5 && Amor >= 1)
        {
            p1.transform.position = new Vector3(0, 0, -2.5f);
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
