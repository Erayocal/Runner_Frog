using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_jump : MonoBehaviour
{
    public float jumpforce = 1f;
    Rigidbody2D rg;
    void Start()
    {
        rg= GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("jump"))
        {
            rg.velocity = Vector2.up * jumpforce;
        }
    }

}
