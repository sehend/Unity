using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deltatime : MonoBehaviour
{

    private float timer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        //saniye cýnsýnden artan sayaç sayaç kurmak için çok önemli kod
        
        timer += 1 * Time.deltaTime;



    }
}
