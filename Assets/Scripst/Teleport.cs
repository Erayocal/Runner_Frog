using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    
    void Start()
    {
        
    }
    bool ck=true;
    void Update()
    { 
            if (transform.position.y < -2f && transform.position.x < 25f && ck == true)
            {
                transform.position = new Vector3(-2.96f, 0.8134f, 0);
            }
    }
}
