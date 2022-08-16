using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAxis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //objeyi ilki sag sola 2 cisi yukarý aþaga

        Input.GetAxis("Horizontal");

        Input.GetAxis("Vertical");
    }
}
