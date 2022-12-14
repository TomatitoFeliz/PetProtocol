using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject comida, nocomida;
    float timer = 4;
    int numero;
    int comidan = 0;
    int nocomidan = 0;

    private void OnTriggerEnter(Collider other)
    {
        var rotation = new Quaternion(0, 180, 180, 0);
        var position = new Vector3(Random.Range(-4.5f, 4.5f), 4.2f, -2.5f);
        if (other.tag == "comida")
        {
            comidan++;
            if (comidan == 5)
            {
                Destroy(other.gameObject);
                if (nocomidan != 3)
                {
                    Instantiate(nocomida, position, rotation);
                }
            }
        }
        if (other.tag == "nocomida")
        {
            nocomidan++;
            if (nocomidan == 4)
            {
                Destroy(other.gameObject);
                if (comidan != 4)
                {
                    Instantiate(comida, position, rotation);
                }
            }
        }
    }

    public void repetir()
    {
        InvokeRepeating("RespawnAlimentar", 0f, 1f);
    }
    public void RespawnAlimentar()
    {
        Update();
        if (timer < 1)
        {
            timer = 4;
            var rotation = new Quaternion(0, 180, 180, 0);
            var position = new Vector3(Random.Range(-4.5f, 4.5f), 4.2f, -2.5f);
            numero = Random.Range(1, 3);
            if (numero == 1 && comidan != 4)
            {
                Instantiate(comida, position, rotation);
            }
            if (numero == 1 && comidan == 4 && nocomidan != 3)
            {
                Instantiate(nocomida, position, rotation);
            }
            if (numero == 2 && nocomidan != 3)
            {
                Instantiate(nocomida, position, rotation);
            }   
            if (numero == 2 && nocomidan == 3 && comidan != 4)
            {
                Instantiate(comida, position, rotation);
            }
            else if (nocomidan != 3 && comidan != 4)
            {
                RespawnAlimentar();
            }
        }
        Debug.Log(timer);
        Debug.Log(numero);
    }
    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;       
        }
    }
}
