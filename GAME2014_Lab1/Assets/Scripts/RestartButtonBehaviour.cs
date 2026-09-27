using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonBehaviour : MonoBehaviour
{
    public void OnRestartButtonPressed()
    {
        Debug.Log("Restart Button Pressed");
        SceneManager.LoadScene("Play");
    }
}
