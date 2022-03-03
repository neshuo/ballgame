using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fisico3Colisiones : MonoBehaviour
{
    public float forceValue; //Fuerza lineal
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
        if (Input.GetButtonDown("Jump") && Mathf.Abs(rb.velocity.y)<0.01f) 
            rb.AddForce(Vector3.up * jumpValue, ForceMode.Impulse);

    }
    void FixedUpdate() {
        //Queremos empujar(aplicar una fuerza constante) a nuestra esfera
        rb.AddForce(new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"))*forceValue);                
    }

    void OnCollisionEnter(Collision coll) {
        if(coll.gameObject.tag == "Obstaculo"){
            //De momento, solo imprimimos que hemos detectado una colisión
            Debug.Log("Colisión!");
            Destroy(coll.gameObject);
        }
    }

    
}
