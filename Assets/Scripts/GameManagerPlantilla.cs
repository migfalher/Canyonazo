using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public GameObject numBalasText;
    static int numBalas = 0;
   
    void Start()
    {
        // Buscar el GO del texto
    }

    void Update()
    {        
        // De momento nada
    }

    static public void ResetearBalas()
    {
        // Poner el número de balas a cero y cambiar el texto del canvas
    }

    static public void IncNumBalas()
    {
        // Incrementar el número de balas y cambiar el texto del canvas
    }

    static public void DecNumBalas()
    {
        // Decrementar el número de balas y cambiar el texto del canvas
    }
}
