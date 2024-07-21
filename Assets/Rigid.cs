using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigid : MonoBehaviour
{
    Rigidbody2D rg;
    Vector3 movement = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {

        rg = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetAxis("Horizontal"));
        Debug.Log(Input.GetAxis("Vertical"));
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        if (movement != Vector3.zero)
        {
            rg.AddForce(movement);
            
        }
        
        
    }
}
