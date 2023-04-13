using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class Player : MonoBehaviour

    {
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    private bool isGrounded;
    public CharacterController controller;

    [SerializeField] private ParticleSystem particulas;


    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Cambio de los valores de entrada de movimiento a WASD
        /*if (Input.GetKey(KeyCode.A))
        {
            horizontal = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            horizontal = 1f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            vertical = 1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            vertical = -1f;
        }*/

        Vector3 movement = new Vector3(horizontal, 0f, vertical).normalized;
        transform.Translate(movement * moveSpeed * Time.deltaTime);
       
        if(movement.magnitude >= 0.1f){
            
            controller.Move(movement*moveSpeed*Time.deltaTime);
        }


        // Cambio de la tecla de salto a espacio
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            particulas.Play();
        }
    }
        
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Ground")
            {
                isGrounded = true;
            }
        }
        public Vector2 MouseInput(){

            float x= Input.GetAxis("Mouse X");
            float y= Input.GetAxis("Mouse Y");

            return new Vector2(x, y);

    }
}
    






