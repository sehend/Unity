using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // GetMouseButton masusa bas�p ve bas�l� tutugun surece isler
    // 2.si space tusuna bast�g�n zaman i�ler
    void Update()
    {
        Input.GetMouseButton(0);


        Input.GetKey(KeyCode.Space);
    }
}
