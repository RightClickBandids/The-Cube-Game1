

using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollition : MonoBehaviour
{
    public playerMovement Move;
    
   
   void OnCollisionEnter(Collision CollisionInfo)
    {

        //What happens if collision with player
        
        if (CollisionInfo.collider.tag == "Obstacles")
        {
            Debug.Log("PERDISTE :c ");
            Move.enabled = false;
            

        }
        if (CollisionInfo.collider.tag == "Finish")
        {
            Debug.Log("Ganaste c:");
            Move.enabled = false;
            

        }
    }
}
