

using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollition : MonoBehaviour
{
    public playerMovement Move;
    public GameObject GameManager;
    
   
   void OnCollisionEnter(Collision CollisionInfo)
    {

        //What happens if collision with player
        
        if (CollisionInfo.collider.tag == "Obstacles")
        {
            
            Move.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            


        }
        if (CollisionInfo.collider.tag == "Finish")
        {
            
            Move.enabled = false;
            

        }
    }
}
