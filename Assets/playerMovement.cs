using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce;
    public float SidewaysForce;
    public float UpForce;
    // Start is called before the first frame update
    void Start()
    {

        //nice :3
        forwardForce = -350f;
        SidewaysForce = 3000f;
        UpForce = 0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if ( Input.GetKey("d"))
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, UpForce * Time.deltaTime, 0);
        }

    }
}
