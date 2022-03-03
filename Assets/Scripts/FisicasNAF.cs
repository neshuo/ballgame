using System.Linq;
using System.Timers;
using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FisicasNAF : MonoBehaviour
{
    public float forceValue;
    public float jumpValue;
    private Rigidbody rb;

    public int contador=0;
    public Text textoContador;
    public Text textoGanar;

    public AudioClip Sspeed;
    public AudioClip Smoneda;

    private float speed;
    private float tiempo=0.0f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        textoGanar.text = "";
        setTextoContador();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate() {
        //Queremos empujar(aplicar una fuerza constante) a nuestra esfera
        rb.AddForce(new Vector3(Input.GetAxis("Horizontal"),0.0f,Input.GetAxis("Vertical"))*forceValue);                
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="coleccionables"){
            other.gameObject.SetActive (false);
            contador++;
            setTextoContador();
            AudioSource.PlayClipAtPoint(Smoneda,Camera.main.transform.position);
        }

        if(other.gameObject.tag=="upgradeSpeed"){
            other.gameObject.SetActive (false);
            StartCoroutine(TimedStuff());
            AudioSource.PlayClipAtPoint(Sspeed,Camera.main.transform.position);
        }

        if(other.gameObject.tag=="Enemigo"){
            Destroy(rb);
            textoGanar.text= "Perdiste...";
        }
    }

    void setTextoContador(){
        textoContador.text = "Contador: " + contador.ToString(); 
        if (contador == 8){
	        textoGanar.text = "¡Ganaste!";
            Destroy(rb);
        }
    }

    IEnumerator TimedStuff () {
        //Do some stuff
        forceValue=forceValue+10;
        //Wait for time
        yield return new WaitForSeconds(10.0f);
        forceValue=forceValue-10;
        //Do some other stuff 3.2 seconds later
    }

} 
