using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisico3BColisiones : MonoBehaviour
{
    public float fuerzaLineal = 10.0f; //Fuerza lineal
    public float fuerzaGiro = 5.0f; //Fuerza angular
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

    void FixedUpdate() {
           
        //ejemplo2: El cubo se desplaza adelante/atrás
        float aceleracion = Input.GetAxis("Vertical");  //flechas up/down
        float giro = Input.GetAxis("Horizontal");       //flechas izda/dcha
        //Aplicamos nuestras fuerzas sobre el Rigidbody: No utilizamos el Translate
        rb.AddForce(transform.forward * aceleracion * fuerzaLineal); //no se mueve tan facilmente por el rozamiento
        rb.AddTorque(transform.up * giro * fuerzaGiro);
    }

    void OnCollisionEnter(Collision col) {
        //Si hemos colisionado con un objeto de tipo Bonus
        if (col.gameObject.tag == "Bonus")
        {  //Destruir el objeto con el que hemos colisionado
            Destroy (col.gameObject);
        }
        if (col.gameObject.tag == "Enemigo")
        {
            //Si chocamos contra un enemigo, nos destruimos nosotros
            Destroy (this.gameObject);
        }
    }
}
