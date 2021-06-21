using System;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    private float lockPos = 0f;

    public float mouseSensitivity = 300f;
    public GameObject player;

    float xRotation = 0f;
    void Start()
    {
        player = GameObject.Find("Player");
        // hides curson and locks it
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        //locks the camera on x axis 
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
   
        transform.rotation = Quaternion.Euler(xRotation, transform.rotation.eulerAngles.y, lockPos);

        transform.Rotate(Vector3.up * mouseX);
    }



}
