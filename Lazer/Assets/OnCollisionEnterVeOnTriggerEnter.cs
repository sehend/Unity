using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEnterVeOnTriggerEnter : MonoBehaviour
{
    // Start is called before the first frame update

    //iki degen objenin birinin içinde RigitBody olmak zorunda

    private void OnCollisionEnter(Collision col)
    {
        print(col.gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
