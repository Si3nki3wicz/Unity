using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drzwi : MonoBehaviour
{
    [SerializeField] private Transform room1;
    [SerializeField] private Transform room2;
    [SerializeField] private CameraController cam;
    public bool czy_mozna = true;



    private void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if(collision.transform.position.y < transform.position.y)
            {
                if (czy_mozna == true)
                {
                    cam.MoveToNewRoom(room2);
                }
            }
            else
            {
                if (czy_mozna == true)
                {
                    cam.MoveToNewRoom(room1);
                }
            }
        }
    }
}
