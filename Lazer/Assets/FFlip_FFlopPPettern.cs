using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FFlip_FFlopPPettern : MonoBehaviour
{

    public float speed;

    bool is_on;

    RaycastHit hit;

    [SerializeField] GameObject flahslight;
    void Start()
    {
        is_on = true;
    }
    void Update()
    {

        Vector3 PlayerInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        Vector3 moveVelocity = PlayerInput * Time.deltaTime * speed;

        print(PlayerInput);

        transform.Translate(moveVelocity);


        if (Input.GetKeyDown(KeyCode.F))
        {
            if (is_on)
            {
                flahslight.GetComponent<Light>().enabled = false;

                is_on = false;
            }
            else
            {
                flahslight.GetComponent<Light>().enabled = true;

                is_on = true;
            }
        }



        


        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.transform.position,transform.forward,out hit, Mathf.Infinity))
            {
                if (hit.collider.gameObject.tag == "Enemy")
                {
                    Destroy(hit.collider.gameObject);
                }
            }
            
        }

    }
}
