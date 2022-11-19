using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public AudioSource saw;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Cube")
        {
            Destroy(collision.gameObject);
            saw.Play();
            
        }
    }

}
