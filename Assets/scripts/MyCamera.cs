using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera : MonoBehaviour
{
   
    [SerializeField] Transform target;
    Vector3 offset;

    private void Start()
    {
        offset = transform.position - target.position;
    }

    private void fixedUpdate()
    {
        transform.position = target.transform.position + offset; // posicion la camara donde esta el pj + el offset
    }


    //min 46
  //Hola
}
