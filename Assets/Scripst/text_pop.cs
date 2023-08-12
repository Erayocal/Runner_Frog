using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class text_pop : MonoBehaviour
{
    public GameObject textpop;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name== "Idle")
        {
            textpop.SetActive(true);
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Idle")
        {
            textpop.SetActive(false);
        }

    }
    
    
}
