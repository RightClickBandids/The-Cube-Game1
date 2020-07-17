using UnityEngine.SceneManagement;
using UnityEngine;


public class GameManager : MonoBehaviour {
    bool gameHasEnded = false;
    //Time after collition or error
    public float RestartDelay = 1f;

    public void EndGame() {

        if (gameHasEnded == false)
        {
            gameHasEnded = true;
        Debug.Log("Gameover");
            
            Invoke("Restart", RestartDelay);
        }
    }

    public GameObject CompleteLevelUI;

    public void CompleteLevel()
    {

        CompleteLevelUI.SetActive(true);

    }
    void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
