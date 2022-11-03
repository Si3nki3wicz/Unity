using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie_4 : MonoBehaviour
{
    public float speed = 5;
    public float rotationspeed = 5;
    Vector3 Wektor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print("Poruszanie za pomoc¹ strza³ek");
        Wektor = transform.localPosition;
        Wektor.y += Input.GetAxis("Jump") * speed * Time.deltaTime;
        Wektor.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        Wektor.z += Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.localPosition = Wektor;

    }
}
