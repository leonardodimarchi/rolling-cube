using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isGameEnded = false;

    public float restartDelay = 1f;

    public void GameOver()
    {
        if (isGameEnded)
        {
            return;
        }

        isGameEnded = true;
        Invoke("Restart", restartDelay);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
