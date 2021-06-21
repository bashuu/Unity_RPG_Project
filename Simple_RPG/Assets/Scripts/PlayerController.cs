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

    // Update is called once per frame
    void Update()
    {
        float verInput = Input.GetAxis("Vertical");
        float horInput = Input.GetAxis("Horizontal");
        transform.Translate(focalPoint.transform.forward * Time.deltaTime * speed * verInput);

        transform.Translate (focalPoint.transform.right * horInput * speed * Time.deltaTime);

    }
}
