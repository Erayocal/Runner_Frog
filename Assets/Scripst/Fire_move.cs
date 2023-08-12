using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_move : MonoBehaviour
{
    Rigidbody2D rg;
    public float sp;
    bool ck = true;
    void Start()
    {
        rg= GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Ck1"))
        {
            ck = false;
        }
        if (collision.gameObject.CompareTag("Ck2"))
        {
            ck = true;
        }
    }
    void Update()
    {
        if (ck == true)
        {
            rg.velocity = Vector2.up * sp;
        }
        if (ck == false)
        {
            rg.velocity = Vector2.down * sp;
        }
    }
}
