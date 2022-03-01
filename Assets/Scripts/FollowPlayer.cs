
using System.Security.Cryptography;
using UnityEngine;
using System;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public int offsetZ;
    public  Vector3 offsetV3;
    Vector3 mCamera = new Vector3 (0,5,0);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Code to move camera to player

        this.transform.position = player.position + offsetV3;
        //mCamera[2] = (player.position.z) + offsetZ;
        //this.transform.position = mCamera;
    }
}
