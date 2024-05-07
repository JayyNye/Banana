using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void QuitGame()
    {
        Debug.Log("Exit Pressed");
        Application.Quit();
    }
}
