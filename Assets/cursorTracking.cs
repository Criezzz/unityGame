using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class cursorTracking : MonoBehaviour
{
    public float speed = 1000f;
    [SerializeField] private Vector3 mousePos;
    Rigidbody2D rg;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
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