using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spiked_ball : MonoBehaviour
{
    Rigidbody2D rg;
    public float sp;
    public float spd;
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
        if(ck==true)
        {
            transform.Rotate(0f, 0f, sp * Time.deltaTime);
        }
        if(ck==false)
        {
            transform.Rotate(0f, 0f, spd * Time.deltaTime);
        }
    }
}
