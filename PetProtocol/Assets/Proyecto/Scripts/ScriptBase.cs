using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScriptBase : MonoBehaviour
{
    [SerializeField]
    GameObject MenuInicial, SelectorG�nero;
    [SerializeField]
    TMP_InputField nombreEscrito;
    [SerializeField]
    TMP_Text nombreSlime;
    private void Start()
    {
        MenuInicial.SetActive(true);
        SelectorG�nero.SetActive(false);
    }
    public void SelectorPet()
    {
        MenuInicial.SetActive(false);
        SelectorG�nero.SetActive(true);
        nombreSlime.text = nombreEscrito.text;
        Debug.Log("nombreEscrito: " + nombreEscrito.text.ToString());
    }

    public void Female(GameObject prefabFemale)
    {
        SelectorG�nero.SetActive(false);
        Instantiate(prefabFemale, new Vector3(0, 3, 0), Quaternion.identity);
    }
    public void Male(GameObject prefabMale)
    {
        SelectorG�nero.SetActive(false);
        Instantiate(prefabMale, new Vector3(0, 3, 0), Quaternion.identity);
    }
}
