using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField]
    GameObject p1, p2, p3, p4;
    public void Derecha()
    {

        p1.transform.Translate(new Vector3(1, 0, 0));
        p2.transform.Translate(new Vector3(1, 0, 0));
        p3.transform.Translate(new Vector3(1, 0, 0));
        p4.transform.Translate(new Vector3(1, 0, 0));
    }
    public void Izquierda()
    {
        p1.transform.Translate(new Vector3(-1, 0, 0));
        p2.transform.Translate(new Vector3(-1, 0, 0));
        p3.transform.Translate(new Vector3(-1, 0, 0));
        p4.transform.Translate(new Vector3(-1, 0, 0));
    }
}
