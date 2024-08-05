using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager2 : MonoBehaviour
{
    //public void Awake()
    //{
    //    DontDestroyOnLoad(this);
    //}
    public void goGame()
    {
        SceneManager.LoadScene("inGame");
    }
    public void doExitGame() { Application.Quit(); }
}
