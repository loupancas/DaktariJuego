using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class Player : MonoBehaviour

    {
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    
    public CharacterController controller;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    public Transform cam; 

    public float gravity=-9.81f;
    public Transform groundCheck;
    public float sphereRadius=0.3f;
    public LayerMask groundMask;
    bool isGrounded;
    public float jumpHeight = 1.5f;

    Vector3 velocity;

    [SerializeField] private ParticleSystem particulas;


    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position,sphereRadius,groundMask);

        if(isGrounded && velocity.y < 0){

            velocity.y = -2f;

        }


        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical).normalized;
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded){

            velocity.y = Mathf.Sqrt(jumpHeight * -2.5f * gravity);

        }
        velocity.y += gravity*Time.deltaTime;
        controller.Move(velocity*Time.deltaTime);

       
        if(movement.magnitude >= 0.1f){
            
            float targetAngle = Mathf.Atan2(movement.x, movement.z)* Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle= Mathf.SmoothDampAngle(transform.eulerAngles.y,targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            Vector3 moveDir = Quaternion.Euler(0f,targetAngle,0f) * Vector3.forward;
            transform.rotation = Quaternion.Euler(0f,angle,0f);
            controller.Move(moveDir.normalized*moveSpeed*Time.deltaTime);
            
        }
      

    }
}
    






