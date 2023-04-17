using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public Transform spawnPoint;

    public GameObject potion;

    public float shotForce = 1500f;

    public float shotRate = 0.5f;

    private float shotRateTime=0;
    
    

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            //if(Time.time>shotRateTime)
            {
                GameObject newPotion;

                newPotion = Instantiate(potion, spawnPoint.position, spawnPoint.rotation);
                newPotion.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotForce);

                shotRateTime = Time.time + shotRateTime;

                Destroy(newPotion,1);

            }

            
        }








    }
}
