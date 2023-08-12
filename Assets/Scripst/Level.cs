using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{

    public void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "finish")
        { 
            SceneManager.LoadScene(2); 
        }
        if(col.gameObject.name == "finish2")
        {
            SceneManager.LoadScene(3);
        }
        if(col.gameObject.name == "finish3")
        {
            SceneManager.LoadScene(4);
        }
        if(col.gameObject.name == "End")
        {
            SceneManager.LoadScene(5);
        }
    }
    
    




}
