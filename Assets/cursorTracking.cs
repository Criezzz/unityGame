using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;



public class cursorTracking : MonoBehaviour
{
    public SceneManger manager;
    public float speed = 300f;
    
    [SerializeField] private Vector3 mousePos;
    Rigidbody2D rg;

    // Start is called before the first frame update
    void Start()
        
    {
        rg = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        
        mousePos = Input.mousePosition;
        mousePos.z = 10f;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
    }

    void FixedUpdate()
    {
        Vector2 direction = (mousePos - transform.position);
        rg.velocity = direction * Time.deltaTime * speed;

    }
}
