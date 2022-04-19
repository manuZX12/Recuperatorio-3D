using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recuperatorio : MonoBehaviour
{
    public bool FRU;
    public bool CHO;
    public bool DDL;
    public int cantidad_gramos;
    float preciofinal;
    float descuento;
    float descuento2;
    float descuentoaplicado;
    public float altura;
    public int edad;
    void Start()
    {
        if(cantidad_gramos < 250 || cantidad_gramos > 3000 || altura < 1.2 || edad < 13)
        {
            Debug.Log("Error");
        }
        else if (cantidad_gramos > 250 || cantidad_gramos < 3000 || FRU == true)
        {
            preciofinal = (cantidad_gramos * 0.5f);
            descuento = (10 * preciofinal);
            descuento2 = (descuento / 100);
            descuentoaplicado = (preciofinal - descuento2);
            Debug.Log("Usted debe pagar " +descuentoaplicado);
        }
        else if (cantidad_gramos > 250 || cantidad_gramos < 3000)
        {
            preciofinal = (cantidad_gramos * 0.5f);
            Debug.Log("Usted debe pagar " + preciofinal);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
