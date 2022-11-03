using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie2_Move : MonoBehaviour
{
    
    public float speed = 10f;
    public Rigidbody rb;
    public bool MoveBack;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (MoveBack == true)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (rb.position.x > 10)
            {
                MoveBack = false;
            }
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (rb.position.x < 0)
            {
                MoveBack = true;
            }
        }

    }
}
