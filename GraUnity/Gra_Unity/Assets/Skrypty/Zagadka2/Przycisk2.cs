using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Przycisk2 : MonoBehaviour
{
    public GameObject sciana1;
    public GameObject sciana1PO;
    public GameObject sciana1PRZED;
    int speed = 2;

    // Start is called before the first frame update
    private void Start()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.tag == "Kostka1")
        {
            sciana1.transform.position = Vector2.MoveTowards(sciana1.transform.position, sciana1PO.transform.position, speed * Time.deltaTime);
        }
        if (collision.tag == "Player")
        {
            sciana1.transform.position = Vector2.MoveTowards(sciana1.transform.position, sciana1PO.transform.position, speed * Time.deltaTime);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Kostka1")
        {
            sciana1.transform.position = Vector2.MoveTowards(sciana1.transform.position, sciana1PRZED.transform.position, 20);
        }
        if (collision.tag == "Player")
        {
            sciana1.transform.position = Vector2.MoveTowards(sciana1.transform.position, sciana1PRZED.transform.position, 20);
        }
    }
}
