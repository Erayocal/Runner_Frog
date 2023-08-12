using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.SceneManagement;
public class door_open : MonoBehaviour
{
    Rigidbody2D rg;
    public float doorsp;
    public GameObject player;
    public static int fruitc = 0;
    private bool fd=false;
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (fruitc == 3)
        {
                if (player.transform.position.x > 10.181f)
                {
                    
                    if (Input.GetKey(KeyCode.E))
                    {
                        rg.velocity = Vector2.down * doorsp;

                    }
                    else if (transform.position.y <= 0.566f)
                    {
                        rg.velocity = Vector2.zero;
                    }
                }
        }
        string currentScene = SceneManager.GetActiveScene().name;

        if(currentScene=="Level03")
        {
                if (player.transform.position.x > 18.773f && fruitc==3)
                {
                    if (Input.GetKey(KeyCode.E)) {fd= true;}
                    if(fd==true) { rg.velocity = Vector2.down * doorsp; }

                }
            
        }
        

    }
}

