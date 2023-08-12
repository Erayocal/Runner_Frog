using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class platformmove : MonoBehaviour
{

    bool ck=true;
    public float sp;
    Rigidbody2D rg;
    void Start()
    {
        rg= GetComponent<Rigidbody2D>();
        
    }


    void FixedUpdate()
    {
        string currentScene = SceneManager.GetActiveScene().name;

        if (currentScene == "Level01")
        {
            if (ck == true)
            {
                rg.velocity = Vector2.right * Time.deltaTime * sp;
                if (transform.position.x >= 13.5f)
                {
                    rg.velocity = Vector2.zero;
                    ck = false;
                }
            }
            else if (ck == false)
            {
                rg.velocity = Vector2.left * Time.deltaTime * sp;
                if (transform.position.x <= 10.6f)
                {
                    rg.velocity = Vector2.zero;
                    ck = true;
                }
                return;
            }
        }
        if(currentScene=="Level03")
        {
            if (ck == true)
            {
                rg.velocity = Vector2.right * Time.deltaTime * sp;
                if (transform.position.x >= 4.6f)
                {
                    rg.velocity = Vector2.zero;
                    ck = false;
                }
            }
            else if (ck == false)
            {
                rg.velocity = Vector2.left * Time.deltaTime * sp;
                if (transform.position.x <= 1.7f)
                {
                    rg.velocity = Vector2.zero;
                    ck = true;
                }
                return;
            }
        }
        




    }
}
