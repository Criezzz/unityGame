using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ringMovement : MonoBehaviour
{
    Rigidbody2D rg;
    float speed = 300f;
    Vector3 diamondPos;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        diamondPos = new Vector3(0.5f, 0f, 10f);
        Vector2 direction = (diamondPos - transform.position).normalized;
        
        rg.velocity = direction * Time.fixedDeltaTime * speed;
    }

   
}
