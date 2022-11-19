using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gun1 : MonoBehaviour
{

    public float nextTimeToFire = 0f;
    public float damage =10f;
    public float range = 100f;
    public float force = 20f;
    public float fireRate = 10f;
    public int balas = 10;
    public TextMeshProUGUI texto3;
    public AudioSource disparo;


    public Camera fpsCam;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        texto3.SetText("x " + balas);
       
        if(balas >= 0 )
        {
            
             if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            if(balas > 0) {
                nextTimeToFire = Time.time + 1f / fireRate;
                Shoot();
                balas -= 1;
            } 
             
            
        }
        }
        if (balas <= 0)
        {
            balas = 0;
        }
    }

    /*Metodo para aumentar balas*/
    public void AumentaBalas(int cantidad)
     {
        balas += cantidad; 
    }


    void Shoot ()
        {
        /*shootSound.Play();*/
        /*Disparo con Raycast hit*/
        disparo.Play();
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            target target = hit.transform.GetComponent<target>();
            if (target!=null)
            {
                target.TakeDamage(damage);
                
                
            }
            if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * force);
            }
        }
    }
}
