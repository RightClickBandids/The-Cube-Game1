using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text Scoretext;
    public float scoremultiplier;
    public float scoreAmount;
    public float pointsIncreasedPerSecond;

    void Start()
    {
        //Multiplier of score
        scoreAmount = 0f;
        pointsIncreasedPerSecond = 40f;
    }

   //Score based on position
    void Update()
    {

        //Debug.Log(player.position.z - 28.4);

        Scoretext.text = Convert.ToString((int)scoreAmount);
        scoreAmount += pointsIncreasedPerSecond * Time.deltaTime;
      
     }
}
