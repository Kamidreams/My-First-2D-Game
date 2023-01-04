using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }
    public void Info()
    {
        SceneManager.LoadScene(1);
    }
     public void Game()
    {
        SceneManager.LoadScene(2);
    }
     public void Winner()
    {
        SceneManager.LoadScene(3);
    }
}
