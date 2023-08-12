using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collect_fruit : MonoBehaviour
{
    
    public int fruit = 0;
    
    [SerializeField] private Text fruit_text;
    [SerializeField] private AudioSource fruitaudioSource;
    void Update()
    {
        door_open.fruitc=fruit;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("fruit"))
        {
            Destroy(collision.gameObject);
            fruit++;
            fruit_text.text = "Fruits:" + fruit + "/3";
            fruitaudioSource.Play();
            
        }
        

        
    }
}
