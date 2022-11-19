using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
     public float health = 50f;
    public AudioSource saw;
    public puntaje puntaje;
    public int puntos = 1 ;

        void Start()
    {
        puntaje=FindObjectOfType<puntaje>();
    }
     
        public void TakeDamage (float amount)
        {
        health -=  amount;
        if (health <= 0f)
        {
            Die();
        }
        }


        void Die () 
        {
            
            puntaje.contador+=puntos;
            Destroy(gameObject);
            saw.Play();
            
            
        }
}
