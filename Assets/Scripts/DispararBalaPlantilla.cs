using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DispararBala : MonoBehaviour
{
    GameObject posInicial;
    GameObject posFinal;
    GameObject canyon;

    public     GameObject prefabBala;
    GameObject balaInstanciada;

    void Start()
    {
        // Buscamos los GO (InicioBala, FinalBala
        posInicial = ...;
        posFinal   = ...;
        canyon     = ...;
    }

    // Update is called once per frame
    void Update()
    {
        // Cambiamos el color del cañón de blanco a rojo cuando la bala está cerca
        int cerca = 10;
        if (balaInstanciada != null)
        {
            // Comprobar la distancia entre la última bala instanciada (balaInstanciada)
            // y la posición del cañon (canyon) para colorear o no dicho cañón
        }
    }

    private void OnMouseDown()
    {
        balaInstanciada = Instantiate(...);
        RigidBody rb = ...;     
        
        Vector3 direccion = posFinal.transform.position - posInicial.transform.position;
        
        // Añadir  fuerza en el vector dirección
        // AddForce(...)

        // Tenemos que avisar al GameManager para que incremente el número de balas en 1, y lo muestre en el canvas
        GameManager.IncNumBalas();
    }

}
