using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FidicoNAF : MonoBehaviour
{
    public float forceValue;
    public float jumpValue;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate() {
        //Queremos empujar(aplicar una fuerza constante) a nuestra esfera
        rb.AddForce(new Vector3(Input.GetAxis("Horizontal"),0.0f,Input.GetAxis("Vertical"))*forceValue);                
    }
}
