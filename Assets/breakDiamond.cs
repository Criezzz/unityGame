using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public SceneManger manager;
    public GameObject mouse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        manager.showUi();
            
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("mouse")){
            mouse.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
