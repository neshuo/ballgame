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
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        textoGanar.text="";
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
            Debug.Log(contador)
            setTextoContador();
        }
    }

    void setTextoContador(){
        textoContador.text = "Contador: " + contador.ToString(); 
        if (contador == 12){
	        textoGanar.text = "¡Ganaste!";
        }
    }


} 
