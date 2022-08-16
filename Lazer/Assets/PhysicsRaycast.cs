using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsRaycast : MonoBehaviour
{
    void Start()
    {
        
    }



    RaycastHit hit;

    // hit lazerin dokundugu objenin bilgilerini al�r

    // Mathf.Infinity lazerin boyutu sonsuza kadar gitsin veya say� ilede belirlene bilir

    // drawrange de Mathf.Infinity �al��maz


    void Update()
    {
        Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity);

        if (Physics.Raycast(transform.position,transform.forward, out hit,Mathf.Infinity))
        {
            print(hit.collider.gameObject.name);
        }
    }
}
