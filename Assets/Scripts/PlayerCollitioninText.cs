using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollitioninText : MonoBehaviour
{
    
    public Text score;

void OnCollisionEnter(Collision CollisionInfo)
{

    //What happens if collision with player

    if (CollisionInfo.collider.tag == "Obstacles")
    {
        
        
        score.enabled = false;

    }
    if (CollisionInfo.collider.tag == "Finish")
    {
        
       
        score.enabled = false;

    }
}
}
