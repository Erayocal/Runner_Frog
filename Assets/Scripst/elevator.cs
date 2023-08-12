using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class elevator : MonoBehaviour
{
    Rigidbody2D rg;
    public float sp;
    public GameObject player;
    void Start()
    {
        rg= GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(player.transform.position.x> 22.03)
        {
            rg.velocity = Vector2.up * sp;   

        }
        string currentScene = SceneManager.GetActiveScene().name;

        if (currentScene == "Level04")
        {
            if (player.transform.position.y < 0.125)
            {
                rg.velocity = Vector2.up * sp;

            }
        }
    }
}
