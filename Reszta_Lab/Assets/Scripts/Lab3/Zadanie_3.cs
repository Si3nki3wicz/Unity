using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zadanie_3 : MonoBehaviour
{
    public GameObject[] point;
    int x = 0;
    public float speed;
    float y = 1;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Vector3.Distance(point[x].transform.position, transform.position) < y)
        {
            this.transform.Rotate(0.0f, -90.0f, 0.0f, Space.Self);
            x++;
            if(x >= point.Length)
            {
                x = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, point[x].transform.position, Time.deltaTime * speed);
        
    }
}
