using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsRaycast : MonoBehaviour
{
    void Start()
    {
        
    }



    RaycastHit hit;

    // hit lazerin dokundugu objenin bilgilerini alýr

    // Mathf.Infinity lazerin boyutu sonsuza kadar gitsin veya sayý ilede belirlene bilir

    // drawrange de Mathf.Infinity çalýþmaz


    void Update()
    {
        Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity);

        if (Physics.Raycast(transform.position,transform.forward, out hit,Mathf.Infinity))
        {
            print(hit.collider.gameObject.name);
        }
    }
}
