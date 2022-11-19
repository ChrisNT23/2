using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public GameObject MyTarget;
    
    public int range;
    public int damage = 1;
    public int MoveSpeed = 3;
    public Animator animacion;
    public int distanciaMinima; 
   /* public bool danio = true;*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*Persigue*/
        transform.LookAt(MyTarget.transform);
        float dist = Vector3.Distance(transform.position, MyTarget.transform.position);
        print("Distance to other: " + dist);
        
        if (dist < range) 
        {
           transform.position += transform.forward * MoveSpeed * Time.deltaTime;
           animacion.SetBool("Run", true);

           if(dist <= distanciaMinima) {
            animacion.SetBool("Run", false);
            animacion.SetBool("Attack", true);

          /*  if(danio) {
                Vida nuevo = MyTarget.GetComponent<Vida>();
                nuevo.TakeDamage(damage);
                StartCoroutine(EnableToDamage());  
            }*/

                      
           }
           else {            
            animacion.SetBool("Attack", false);
           }
        }         
         else {
            animacion.SetBool("Run", false);
            animacion.SetBool("Attack", false);
         }


    }

    /*Método para bajar vida al personaje*/  
     void OnCollisionEnter(Collision collision) 
     {
        if(collision.gameObject.CompareTag("Player"))
        {

            Vida nuevo = collision.gameObject.GetComponent<Vida>();
            nuevo.TakeDamage(damage);             
        }

         

    }


/*
    IEnumerator EnableToDamage()
    {
        danio = false;
        yield return new WaitForSeconds(1);
        danio = true;
    }*/

}
