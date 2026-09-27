using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButtonBehaviour : MonoBehaviour
{
    public void OnNextButtonPressed()
    {
        Debug.Log("Next Button Pressed");
        SceneManager.LoadScene("End");
    }

}
