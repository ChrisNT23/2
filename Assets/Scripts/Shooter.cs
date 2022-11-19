using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform mySpawn;

 void Update()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
          Shoot();
           
        }
    }

    void Shoot(){
        Rigidbody bullet;
        bullet = Instantiate(projectile, mySpawn.position, mySpawn.rotation);
        bullet.velocity = mySpawn.TransformDirection(Vector3.forward*100);
        /*Destroy(mySpawn, 5);*/
    }
    



}
