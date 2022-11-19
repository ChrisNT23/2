using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentaVida : MonoBehaviour
{
    public bool destruirAutomatico;
    public Vida Vida;
    public int damage; 

    public int tipo;

    // Start is called before the first frame update
    void Start()
    {
       /* Vida = GameObject.FindGameObjectWithTag("Player").GetComponent<Vida>();*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    public void Efecto() {
        switch(tipo) {
            case 1:
                Vida.health += 5;
                Destroy(gameObject);
            break;
        }
    }*/


    void OnCollisionEnter(Collision collision) 
     {
        if(collision.gameObject.CompareTag("Player"))
        {

            Vida nuevo = collision.gameObject.GetComponent<Vida>();
            nuevo.TakeHealth(damage); 
            Destroy(gameObject);            
        }

         

    }


}
