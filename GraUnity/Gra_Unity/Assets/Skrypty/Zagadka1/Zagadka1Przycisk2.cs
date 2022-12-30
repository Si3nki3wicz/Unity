using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zagadka1Przycisk2 : MonoBehaviour
{
    public GameObject scianaZagSro;
    public GameObject scianaZagGor;

    int speed = 6;
    public bool czy1 = false;
    public bool czy2 = false;


    // Start is called before the first frame update
    private void Start()
    {
    }
    private void Update()
    {
        if (scianaZagSro.transform.position.y >= 5)
        {
            czy1 = false;
        }
        if (scianaZagSro.transform.position.y <= 5)
        {
            czy1 = true;
        }

        if (scianaZagGor.transform.position.y >= 5)
        {
            czy2 = false;
        }
        if (scianaZagGor.transform.position.y <= 5)
        {
            czy2 = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Zagadka")
        {
            if (czy1 == true)
            {
                scianaZagSro.transform.Translate(Vector2.up * speed);

            }
            else
            {
                scianaZagSro.transform.Translate(-Vector2.up * speed);

            }
            if (czy2 == true)
            {

                scianaZagGor.transform.Translate(Vector2.up * speed);
            }
            else
            {

                scianaZagGor.transform.Translate(-Vector2.up * speed);
            }
        }
    }
}
