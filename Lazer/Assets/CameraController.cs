using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private float xRotation = 0f;

    public float mouseSensivity = 2000f;

    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        float mauseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensivity;
        float mauseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensivity;
        xRotation -= mauseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        player.transform.Rotate(Vector3.up * mauseX);
     
    }
}
