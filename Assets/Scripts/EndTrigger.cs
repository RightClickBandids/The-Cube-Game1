using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    public float EndingDelay = 1f;
    public void OnCollisionEnter()
    {

        gameManager.CompleteLevel();
        //Debug.Log("mmm");

    }

}
