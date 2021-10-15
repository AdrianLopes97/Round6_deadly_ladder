using UnityEngine;
using UnityEngine.SceneManagement;

public class RetartGame : MonoBehaviour
{
    public string Game;
    public void Restart()
    {
        SceneManager.LoadScene(Game);
    }
}
