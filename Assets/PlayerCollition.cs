

using UnityEngine;

public class PlayerCollition : MonoBehaviour
{
    public playerMovement Move;
   
   void OnCollisionEnter(Collision CollisionInfo)
    {
        
        if (CollisionInfo.collider.tag == "Obstacles")
        {
            Debug.Log("PERDISTE :c ");
            Move.enabled = false;

        }
        if (CollisionInfo.collider.tag == "Finish")
        {
            Debug.Log("Ganaste c: ");
            Move.enabled = false;

        }
    }
}
