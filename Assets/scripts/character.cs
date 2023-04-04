using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{
    public Vector3 move; // para debugear
    Rigidbody myrig;
    public float speed=200f;
    private void Awake()
    {
        myrig = GetComponent<Rigidbody>(); // capturar el RB se hace una sola vez
    }


    private void fixedUpdate() // fixed update se ejecuta en tiempo determinado , fluye mas el movimiento
    {
        //Input.GetAxis("Horizontal"); // devuelve un flotante de la simulacion de las teclas
                                     // horizontal sale del input manager
                                     // 0 0.1 0.2 hasta 1

        //Input.GetAxisRaw("Horizontal"); // da 0 1 

        //entrada dura
       // Input.GetKeyDown(KeyCode.D);


        //Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); se crea vector 3

        move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); // vector3  ya se creo 


        //if(Input.GetAxis("Horizontal")>0.5f) //serviria para joystick
        {
            //estoy corriendo
        }

        myrig.velocity = move * Time.deltaTime*speed; // se le pasa el move,modifica velocity del rb, su vector 
                                                // time delta time solo depende del time y no de los frames
                                                // velocity depende de las f�sicas de unity pero podemos modificarlo
          
    }
}
