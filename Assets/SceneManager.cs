using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManger : MonoBehaviour
{
    public static SceneManger instance;
    public GameObject ui;
    public GameObject cs;
    //public GameObject timer;
    public string scene;
    public bool ig;
    public Timer t;
    private void Awake()
    {
        ig = false;
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!ig)
        {
            showUi();
        }
        else
        {
            
        }
    }
    public void showUi()
    {
        cs.SetActive(false);
        ig = false;
        Cursor.visible = true;
        cs.GetComponent<BoxCollider2D>().enabled = false;
        Time.timeScale = 0;
        ui.SetActive(true);
        t.resetTime();
    }
    public void startGame() {
        Time.timeScale = 1;
        ig = true;
        Cursor.visible = false;
        cs.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
        ui.SetActive(false);
        Mouse.current.WarpCursorPosition(Input.mousePosition);
        SceneManager.LoadScene(scene);
    }
}
