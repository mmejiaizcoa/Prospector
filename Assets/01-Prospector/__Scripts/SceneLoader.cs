using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene1()
    {
        SceneManager.LoadScene("__Prospector"); 
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("__Golf"); 
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene("mainScene");
    }
}