using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManger : MonoBehaviour
{
    public GameObject prefab;
    public static SceneManger instance;
    public GameObject ui;
    public GameObject cs;
    //public GameObject timer;
    public string scene;
    public bool ig;
    public Timer t;
    public SpriteRenderer cursorState;
    public Sprite cursorInvis;
    public Sprite cursorNormal;
    private void Awake()
    {
        ig = true;
        InvokeRepeating("spawn", 3, 3);
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        Cursor.visible = false;

    }
    // Start is called before the first frame update
    

    void Start()
    {
        cursorState = cs.GetComponent<SpriteRenderer>();
        cursorState.sprite = cursorInvis;
        cs.GetComponent<BoxCollider2D>().enabled = false;
        Mouse.current.WarpCursorPosition(Input.mousePosition);
        Time.timeScale = 1;
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
            if(t.getTime() >= 1)
            {
                cursorState.sprite = cursorNormal;
                cs.GetComponent<BoxCollider2D>().enabled = true;
            }

        }
    }
    public void spawn()
    {
        Instantiate(prefab, new Vector3(Random.Range(-3f, 3f), 7f, 0f),Quaternion.identity);
    }
    public void showUi()
    {
        cs.SetActive(false);
        ig = false;
        Cursor.visible = true;
        //cs.GetComponent<BoxCollider2D>().enabled = false;
        Time.timeScale = 0;
        ui.SetActive(true);
        CancelInvoke("spawn");
    }
    public void startGame() {
        SceneManager.LoadScene(scene);
        ig = true;
        //t.resetTime();
        cursorState.sprite = cursorInvis;
        cs.GetComponent<BoxCollider2D>().enabled = false;
        Mouse.current.WarpCursorPosition(Input.mousePosition);
        Time.timeScale = 1;
        Cursor.visible = false;
        
        cs.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
        ui.SetActive(false);
        
    }
    public void doExitGame() { Application.Quit(); }
}
