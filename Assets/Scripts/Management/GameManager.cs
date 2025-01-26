//Ethan Blomgren
//1/20/2025

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    //VARS
    private static GameManager instance;
    private float playerScore = 0;

    //gets and sets

    //METHODS
    public void AddScore(float anScore)
    {
        playerScore += anScore;

    }
    public void ResetScore()
    {
        playerScore = 0;
    }

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
