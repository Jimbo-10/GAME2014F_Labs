using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonBehaviour : MonoBehaviour
{
    public void OnBackButtonPressed()
    {
        Debug.Log("Back Button Pressed");
        SceneManager.LoadScene("Start");
    }
}
