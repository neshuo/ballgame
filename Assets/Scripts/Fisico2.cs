using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisico2 : MonoBehaviour
{
    public float jumpValue;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //guardamos en la variable el componente RigidBody de la esfera
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //La fuerza que aplicamos aqui es de tipo impulso (de caracter inmediato)
        //Detectamos cuando el jugador pulsa el botón de saltar (barra espaciadora) 
        //También comprobamos que la esfera no está ya en el aire, para que el salto no sea incremental       
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y)<0.01f) //Valor absoluto de la velocidad, si es muy pequeña está en reposo
        {
            //AddForce(Vector3 force, ForceMode mode)
            rb.AddForce(Vector3.up * jumpValue, ForceMode.Impulse);
        }
    }
}
