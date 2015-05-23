using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void PlayButtonClicked()
    {
        Debug.Log("Clicked!");

        Application.LoadLevel("StartScene");
    }

    public void QuitButtonClicked()
    {
        Debug.Log("Quit!");

        Application.Quit();
    }

    public void ReturnToMainMenu()
    {
        Application.LoadLevel("MainMenu");
    }

    public void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            ReturnToMainMenu();
        }
    }
}