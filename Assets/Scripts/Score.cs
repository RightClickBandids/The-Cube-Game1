using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text Scoretext;
    public float Scoremultiplier;

    void Start()
    {
        //Multiplier of score
        Scoremultiplier = 3.696f;
    }

   //Score based on position
    void Update()
    {

        //Debug.Log(player.position.z - 28.4);

        Scoretext.text = (Scoremultiplier * (-player.position.z + 28.4)).ToString("0");
      
     }
}
