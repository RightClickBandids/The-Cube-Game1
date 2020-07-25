﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
    GameManager gameManager = new GameManager();
    public Rigidbody rb;
    public float forwardForce;
    public float SidewaysForce;
    public float UpForce;
    public float maxSpeed;
    public float minSpeed;
    public Text score;
    public Color red;
    
    // Start is called before the first frame update
    void Start()
    {

        //Speeds
        forwardForce = -400f;
        SidewaysForce = 2000f;
        UpForce = 0f;
        UpForce = 3000f;
        maxSpeed = 2000f;
        minSpeed = 2000f;
        red.a = 255;
        red.r = 128;
        red.g = 0;
        red.b = 0;
        //int sum = gameManager.By2(3,3);
        //Debug.Log(sum);

       
    }
    void Update (){}
    // Update is called once per frame
    void FixedUpdate()
    {
        //Application of speeds
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
        if (rb.position.y < -1f)
        {
            score.color = red;
            FindObjectOfType<GameManager>().EndGame();
            
        }
        //Limiting acceletarion
            rb.velocity = new Vector3
            (Mathf.Clamp(rb.velocity.x,-maxSpeed, maxSpeed),
             Mathf.Clamp(rb.velocity.y,-maxSpeed, maxSpeed), 
             Mathf.Clamp(rb.velocity.z,-maxSpeed, maxSpeed));
        
    }


}
