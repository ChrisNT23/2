using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restar : MonoBehaviour
{
    public AudioSource saw;
    public puntaje puntaje;
    // Start is called before the first frame update
    void Start()
    {
        puntaje=FindObjectOfType<puntaje>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "mybullet")
        {
            puntaje.contador-=1;
            Destroy(collision.gameObject);
            saw.Play();
            
        }
    }
}
