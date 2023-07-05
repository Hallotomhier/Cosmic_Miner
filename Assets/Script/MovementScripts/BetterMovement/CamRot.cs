using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRot : MonoBehaviour
{
    public float rotSens = 100f;
    public Transform playerBody;
    float xrot = 0f;


    void Start()
    {
        // Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    { 
        float mouseX = Input.GetAxis("Mouse X") * rotSens * Time.deltaTime; 
        float mouseY = Input.GetAxis("Mouse Y") * rotSens * Time.deltaTime;
        xrot -= mouseY;
        xrot = Mathf.Clamp(xrot, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xrot, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
