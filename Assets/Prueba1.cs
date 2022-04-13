using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba1 : MonoBehaviour
{
    public int taxis;
    public int dias;
    public int lluvia;
    // Start is called before the first frame update
    void Start()
    {
        int combustible;
        combustible = 130;
        int total;
        int lluv;
        int resto;

        resto = dias - lluvia;
        lluv = 120 / 15;
        total = taxis * ((lluvia * (combustible * lluv)) + (resto * (combustible * 6)));

        if (dias < 5)
        {
            Debug.Log("Error");
        }

        else if (lluvia < 0)
        {
            Debug.Log("Error");
        }
        else if (lluvia > dias)
        {
            Debug.Log("Error");
        }
        else
        {
            Debug.Log("Una flota de " + taxis + " unidades trabajando durante " + dias + "dias implicara un gasto de" + total + "pesos en concepto de comsutible");
        }

    }

    
}
