using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 10f;
    private float horzontalInput;

    private void Start()
    {
        
    }

    void Update()
    {
        /* movimiento hacia delante (¡los dos hacen lo mismo!). */

        //transform.Translate(0, 0, 1);
        //transform.Translate(Vector3.forward);

        /* movimiento hacia delante dependiendo de lo que tarda en pasar de un frame a otro, 
        independientemente de la tasa de refresco. siempre avanza lo mismo. */

        //transform.Translate(Vector3.forward *20* Time.deltaTime);

        /*detectar colisiones fisicas (collider) */ /* detectar objetos rigidos (rigidbody) */

        //Detectar el Input Horizontal
        horzontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horzontalInput);


    }
}
