using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacManScript : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 10f;

    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            rb.velocity = Vector3.forward * speed;
        }
        else if (Input.GetKeyDown("a"))
        {
            rb.velocity = Vector3.left * speed;
        }
        else if (Input.GetKeyDown("s"))
        {
            rb.velocity = Vector3.back * speed;
        }
        else if (Input.GetKeyDown("d"))
        {
            rb.velocity = Vector3.right * speed;
        }
    }
}