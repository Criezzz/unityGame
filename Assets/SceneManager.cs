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
    public Button btn;
    public string scene;
    public bool ig;

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
        cs.GetComponent<cursorTracking>().enabled = false;
        ig = false;
        Cursor.visible = true;
        Time.timeScale = 0;
        ui.SetActive(true);
    }
    public void startGame() {
        Time.timeScale = 1;
        Cursor.visible = false;
        Mouse.current.WarpCursorPosition(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        Debug.Log("WARP");
        cs.GetComponent<cursorTracking>().enabled = true;
        ui.SetActive(false);
        ig = true;
    }
}
