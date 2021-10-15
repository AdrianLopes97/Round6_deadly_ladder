using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string Jogo;

    public void ChangeS()
    {
        SceneManager.LoadScene(Jogo);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
