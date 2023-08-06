using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    RaycastHit hit;
   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            if(Physics.Raycast(Camera.main.transform.position,transform.forward,out hit, Mathf.Infinity))
            {
                if (hit.collider.gameObject.tag == "enemy")
                {
                    Destroy(hit.collider.gameObject);
                    Debug.Log("vurdu");
                }
                else
                {
                    Debug.Log("Nothing");
                }
            }
        }
    }
}
