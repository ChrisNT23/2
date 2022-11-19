using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{

    /*
  public GameObject effect;
  public float range = 10f;


  void Update() {
    if(Input.GetMouseButtonDown(0)){
        RaycastHit hit;

        
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, range)){
            Debug.Log(hit.collider.name);
            GameObject _effect = Instantiate(effect, hit.point, Quaternion.identity);
            Destroy(_effect, 0.5f);
        }
        
    }
  }
*/

    private void OnCollisionEnter(Collision myCollision) {
       Destroy(this.gameObject);
    }

  

    

}


