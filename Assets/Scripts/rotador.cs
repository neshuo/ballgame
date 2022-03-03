using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         //Time.deltaTime es el tiempo transcurrido en cada frame (a 60fps, valdrá 1/60s)
        transform.Rotate(new Vector3(0, 60, 0) * Time.deltaTime);
    }
}
