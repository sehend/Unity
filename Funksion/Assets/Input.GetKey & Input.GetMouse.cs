using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // GetMouseButton masusa basýp ve basýlý tutugun surece isler
    // 2.si space tusuna bastýgýn zaman iþler
    void Update()
    {
        Input.GetMouseButton(0);


        Input.GetKey(KeyCode.Space);
    }
}
