
using System;

using UnityEngine;
using UnityEngine.UI;

public class PlayerCollitioninText : MonoBehaviour
{

    public Text score;
    public GameObject text;
    public object _PlayerCollition;
    public Color red;
    public Color green;
    public GameObject ObjectwithScript;






    void OnCollisionEnter(Collision CollisionInfo)
    {
        red.a = 255;
        red.r = 128;
        red.g = 0;
        red.b = 0;


        green.a = 255;
        green.r = 0;
        green.g = 200;
        green.b = 0;

        

        //What happens if collision with player

        if (CollisionInfo.collider.tag == "Obstacles")
        {
           
                score.color = red;
            ObjectwithScript.GetComponent <Score> ().enabled = false;
            //Debug.Log("yesssss");

        }
        if (CollisionInfo.collider.tag == "Finish")
        {

            
            score.color = green;

        }
    }
}

