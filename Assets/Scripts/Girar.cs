using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girar : MonoBehaviour
{
    public float girarx =0;
    public float girary =0;
    public float girarz =0;
 

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(girarx, girary, girarz);
    }
}
