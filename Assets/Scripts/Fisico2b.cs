using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisico2b : MonoBehaviour
{
    public float jumpValue;
    private Rigidbody rb;
    private AudioSource myAudio;
    // Start is called before the first frame update
    void Start()
    {
        //guardamos en la variable el componente RigidBody de la esfera
        rb = GetComponent<Rigidbody>(); 
        myAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //La fuerza que aplicamos aqui es de tipo impulso (de caracter inmediato)   
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y)<0.01f) 
        {
            rb.AddForce(Vector3.up * jumpValue, ForceMode.Impulse);
            myAudio.Play(); //Cuando salta, emitir sonido
        }
    }
}
