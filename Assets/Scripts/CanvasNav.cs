using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasNav : MonoBehaviour
{
    // Vars
    
    // Methods
    public void LoadNextScene(int aIDX)
    {
        SceneManager.LoadScene(aIDX);
    }

    public void LoadStartScreen()
    {
        GameManager.Instance.ResetScore();
        LoadNextScene(0);
    }

    // Accessors

    // Methods

}
