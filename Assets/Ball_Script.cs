using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Ball_Script : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.useGravity = false;
        rb.AddForce(0, 0, 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0 , 0 * Time.deltaTime);
    }
}
