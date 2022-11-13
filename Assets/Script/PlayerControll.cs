using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public GameObject vehical1;
    public GameObject vehical2;
    private float speed = 10.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float verticalInput;
    private float upDown;
    private float leftRight;
    void Start()
    {
        
    }

    
    void Update()
    {
        // INPUT FORM THE USER.
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        upDown = Input.GetAxis("UpDown");
        leftRight = Input.GetAxis("LeftRight");

        // MOVING THE VEHICAL FORWARD.
        vehical1.transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // ROTATING THE VEHICAL.
        vehical1.transform.Rotate(Vector3.up,Time.deltaTime * turnSpeed * horizontalInput);
        // MOVING THE VEHICAL FORWARD.
        vehical2.transform.Translate(Vector3.forward * Time.deltaTime * speed * upDown);

        // ROTATING THE VEHICAL.
        vehical2.transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * leftRight);

    }
}
