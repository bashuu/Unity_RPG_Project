using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public GameObject focalPoint;

    private Rigidbody playerRb;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        float verInput = Input.GetAxis("Vertical");
        float horInput = Input.GetAxis("Horizontal");

        // moves toward camera direction 
        transform.Translate(focalPoint.transform.forward * Time.deltaTime * speed * verInput);
        transform.Translate (focalPoint.transform.right * horInput * speed * Time.deltaTime);

    }
}
