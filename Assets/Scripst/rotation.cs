using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{

    [SerializeField] private float sp = 2f;

    
    void Update()
    {
        transform.Rotate(0,0,360 *sp*Time.deltaTime);
    }
}
