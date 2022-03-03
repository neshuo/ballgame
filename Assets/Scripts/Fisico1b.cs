using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisico1b : MonoBehaviour
{
    public float forceValue; //Fuerza lineal
    public float fuerzaGiro; //Fuerza angular
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //guardamos en la variable el componente RigidBody del cubo
        rb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {
           
        //ejemplo2: El cubo se desplaza solo en el eje Z (adelante/atrás)
        float aceleracion = Input.GetAxis("Vertical");  //flechas up/down
        float giro = Input.GetAxis("Horizontal");       //flechas izda/dcha
        //Aplicamos nuestras fuerzas sobre el Rigidbody: No utilizamos el Translate
        rb.AddForce(transform.forward * aceleracion * forceValue); //no se mueve tan facilmente por el rozamiento
        rb.AddTorque(transform.up * giro * fuerzaGiro);
    }
}
