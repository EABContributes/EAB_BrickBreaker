//Ethan Blomgren
//1/20/2025

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    //VARS
    private static GameManager instance;
    private float playerScore = 0;
    public float PlayerScore { get { return playerScore; } }

    //gets and sets

    //METHODS
    public void AddScore(float anScore)
    {
        playerScore += anScore;
        foreach(ScoreDisplay sd in FindObjectsOfType<ScoreDisplay>())
        {
            sd.ChangeScore();
        }
    }
    public void ResetScore()
    {
        playerScore = 0;
    }
    #region SceneManagement

    public void NextScene()
    {
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextScene >= SceneManager.sceneCountInBuildSettings - 1)
        {
            SceneManager.LoadScene(0);
        } else {
            SceneManager.LoadScene(nextScene);
        }
        if (nextScene == 1) ResetScore();
    }

    public void StartScene()
    {
        SceneManager.LoadScene(0);
    }

    #endregion

    //CONSTRUCTORS

    //ACCESSORS
    public static GameManager Instance
    { get 
        {
            if (instance == null)
            {
                GameObject aGameObject = new GameObject("Game Manager");
                instance = aGameObject.AddComponent<GameManager>();
                DontDestroyOnLoad(aGameObject);

            }
            return instance; 
        }
    }

}
