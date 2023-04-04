using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace player.mov
{

    public class Player : MonoBehaviour
    {
        Rigidbody rigid;
        [SerializeField] float speed =200;

        private void Awake()
        {
            rigid = GetComponent<Rigidbody>();
        }


        private void FixedUpdate()
        {
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));
            rigid.velocity = move*speed*Time.deltaTime; // normalizador frames
        }

        //min 30
        
        public vector2 MousInput(){

            float x= Input.GetAxis["Mouse X"];
            float y= Input.GetAxis["Mouse Y"];

            return new Vector2(x, y);

        }
    }



}


