using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EliminarBalas : MonoBehaviour
{
    GameObject[] balas;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {        
    }
    private void OnMouseDown()
    {
        balas = GameObject.FindGameObjectsWithTag("Bala");
           
        // Recorrer lista de balas y eliminarlas una a una
        // ...
    
        // Ahora debemos avisar al GameManager para que resetee la cuenta de balas a 0 de la variable y el canvas
        GameManager.ResetearBalas();
    }
}
