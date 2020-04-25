using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;

    // instance
    public static GameManager instance;

    void Awake ()
    {
         if(instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            //avoid to erase the score between levels
            DontDestroyOnLoad(gameObject);
        }
    }
    public void AddScore (int scoreToGive)
    {
        score += scoreToGive;
    }

    public void LevelEnd()
    {
        //is this the last level
        if(SceneManager.sceneCountInBuildSettings == SceneManager.GetActiveScene().buildIndex + 1)
        {
            WinGame();
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void WinGame ()
    {

    }

    public void GameOver ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
