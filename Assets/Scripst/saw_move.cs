using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saw_move : MonoBehaviour
{

    bool ck = true;
    public float sp;
    Rigidbody2D rg;
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();

    }


    void FixedUpdate()
    {
        if (ck == true)
        {
            rg.velocity = Vector2.up * Time.deltaTime * sp;
            if (transform.position.y >= 1.3f)
            {
                rg.velocity = Vector2.zero;
                ck = false;
            }
        }
        else if (ck == false)
       {
           rg.velocity = Vector2.down * Time.deltaTime * sp;
           if (transform.position.y <= 0f)
           {
               rg.velocity = Vector2.zero;
               ck = true;
           }
           return;
       }
    }
}
