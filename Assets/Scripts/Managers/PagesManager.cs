using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PagesManager : MonoBehaviour
{
    Scene activeScene;
    string activeSceneName;

    private void Update()
    {
        activeScene = SceneManager.GetActiveScene();
        activeSceneName = activeScene.name;

        if (Input.GetKey(KeyCode.Escape))
        {
            if(activeSceneName == "Menu")
            {
                OnApplicationQuit();
            }

            if(activeSceneName == "Level_01")
            {
                SceneManager.LoadScene("Menu");
            }
        }

        DontDestroyOnLoad(this.gameObject);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}
