using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace player.mov
{

    public class Player : MonoBehaviour
    {
        Rigidbody rigid;
        [SerializeField] float speed =50;

        private void Awake()
        {
            rigid = GetComponent<Rigidbody>();
        }


        void Start()
        {

        }

       
        void Update()
        {

        }

        private void FixedUpdate()
        {
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));
            rigid.velocity = move*speed*Time.deltaTime; // normalizador frames
        }

        //min 30
    }



}


