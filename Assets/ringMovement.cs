using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ringMovement : MonoBehaviour
{
    Rigidbody2D rg;
    float speed = 400f;
    Vector3 diamondPos;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        diamondPos = new Vector3(0.5f, 0f, 10f);
        Vector2 direction = (diamondPos - transform.position);
        rg.velocity = direction * Time.deltaTime * speed;
    }

   
}
