using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasNav : MonoBehaviour
{
    // Methods
    public void LoadNextScene(int aIDX)
    {
        GameManager.Instance.NextScene();
        //SceneManager.LoadScene(aIDX);
    }

    public void LoadStartScreen()
    {
        //GameManager.Instance.ResetScore();
        GameManager.Instance.StartScene();
        LoadNextScene(0);
    }

}
