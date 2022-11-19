using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponControlloer : MonoBehaviour
{
    [Header("General")]
    public LayerMask hittableLayers;
 

    [Header("Shoot Paramaters")]
    public float fireRange = 200;
    public Camera fpsCamera;

    private Transform cameraPlayerTransform;

    private void Start()
    {
        cameraPlayerTransform = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }

    private void Update()
    {
        HandleShoot();
    }

    private void HandleShoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            if (Physics.Raycast(cameraPlayerTransform.position, cameraPlayerTransform.forward, out hit, fireRange, hittableLayers))
            {
              
              /*  Destroy(hit);*/
            } 
        }
    }
}
