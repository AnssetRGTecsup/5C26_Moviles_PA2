using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LLamarp : MonoBehaviour
{
    public Puntaje XD;
    public TextMeshPro Puntaje;

    private void Start()
    {
        Puntaje.text = XD.Puntaje_acumulado.ToString();
    }

}
