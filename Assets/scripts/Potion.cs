using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
           
            Destroy(collision.gameObject);
            
        }
        
        if (collision.gameObject.CompareTag("Ciudadano"))
        {
           
        }


    }
}
