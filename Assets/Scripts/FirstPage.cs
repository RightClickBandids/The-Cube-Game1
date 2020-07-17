using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstPage : MonoBehaviour
{
    public void StartGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
