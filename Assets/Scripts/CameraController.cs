using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{	
    public GameObject jugador; //Variable para referenciar nuestro jugador
	private Vector3 offset; //Variable para registrar la diferencia entre la posición de la cámara y la del jugador

    // Start is called before the first frame update
    void Start()
    {
        jugador=GameObject.Find("player");
        
        //Diferencia entre la posición de la cámara y la del jugador
    	offset = transform.position - jugador.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    	// Se ejecuta cada frame, pero después de haber procesado todo. Es más exacto para la cámara
	void LateUpdate () {
    	transform.position = jugador.transform.position + offset;
    }
}
