using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUIST : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}