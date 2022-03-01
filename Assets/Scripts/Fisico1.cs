using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisico1 : MonoBehaviour
{
    public float forceValue; //Fuerza lineal
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
        
    }

    private void FixedUpdate() {
        //Queremos empujar(aplicar una fuerza constante) a nuestra esfera
        //AddForce(Vector3 force, ForceMode mode = ForceMode.Force) //por defecto
        //https://docs.unity3d.com/ScriptReference/Rigidbody.AddForce.html
        rb.AddForce(new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"))*forceValue);         
    }
}
