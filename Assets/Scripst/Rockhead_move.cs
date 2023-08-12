using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rockhead_move : MonoBehaviour
{
    bool ck2 = true;
    bool ck = true;
    public float sp;
    public float esp;
    Rigidbody2D rg;
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();

    }


    void FixedUpdate()
    {
        if (ck2 == true)
        {
            if (ck == true)
            {
                rg.velocity = Vector2.up * Time.deltaTime * sp;
                if (transform.position.y >= 1.44)
                {
                    rg.velocity = Vector2.zero;
                    ck = false;
                }
            }
            else if (ck == false)
            {
                rg.velocity = Vector2.down * Time.deltaTime * sp;
                if (transform.position.y <= 0.635)
                {
                    rg.velocity = Vector2.zero;
                    ck = true;
                }
                return;
            }
        }
        if ((transform.position.y <= 0.635))
        {
            ck2= false;
            rg.velocity = Vector2.right * Time.deltaTime * sp*esp;
            if (transform.position.x>= 10.240)
            {
                rg.velocity = Vector2.zero;
            }
            
        }
        if (transform.position.x >= 10.240f)
        {
            rg.velocity = Vector2.up * Time.deltaTime * sp;
            if(transform.position.y>= 1.44)
            {
                rg.velocity = Vector2.zero;
                transform.position = new Vector3(8.64f, 1.44f, 0);
                ck2= true;
            }

        }

    }

}
