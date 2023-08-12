using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    public float sp;
    Rigidbody2D rb;
    public Animator animator;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));
        Vector3 v1 = new Vector3(move, 0, 0);
        transform.position += v1 * sp * Time.deltaTime;

        if (move > 0) { transform.eulerAngles = new Vector3(0, 0, 0); }
        else if (move < 0) { transform.eulerAngles = new Vector3(0, 180, 0); }
    }
}
