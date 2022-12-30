using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zagadka1Przycisk3 : MonoBehaviour
{
    public GameObject scianaZagDol;
    public GameObject scianaZagSro;
    public GameObject scianaZagGor;

    int speed = 6;
    public bool czy1 = false;
    public bool czy2 = false;
    public bool czy3 = false;
    public int ktory = 1;


    // Start is called before the first frame update
    private void Start()
    {
    }
    private void Update()
    {

        if (scianaZagDol.transform.position.y >= 5)
        {
            czy1 = false;
        }
        if (scianaZagDol.transform.position.y <= 5)
        {
            czy1 = true;
        }

        if (scianaZagSro.transform.position.y >= 5)
        {
            czy2 = false;
        }
        if (scianaZagSro.transform.position.y <= 5)
        {
            czy2 = true;
        }

        if (scianaZagGor.transform.position.y >= 5)
        {
            czy3 = false;
        }
        if (scianaZagGor.transform.position.y <= 5)
        {
            czy3 = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Zagadka")
        {
            //GD
            if (ktory == 1)
            {
                if (czy3 == true)
                {
                    scianaZagGor.transform.Translate(Vector2.up * speed);

                }
                else
                {
                    scianaZagGor.transform.Translate(-Vector2.up * speed);

                }
                if (czy1 == true)
                {
                    scianaZagDol.transform.Translate(Vector2.up * speed);

                }
                else
                {
                    scianaZagDol.transform.Translate(-Vector2.up * speed);

                }
                
            }
            //DŒ
            if (ktory == 5)
            {
                if (czy1 == true)
                {
                    scianaZagDol.transform.Translate(Vector2.up * speed);

                }
                else
                {
                    scianaZagDol.transform.Translate(-Vector2.up * speed);

                }
                if (czy2 == true)
                {
                    scianaZagSro.transform.Translate(Vector2.up * speed);

                }
                else
                {
                    scianaZagSro.transform.Translate(-Vector2.up * speed);

                }
                
            }
            //G
            if (ktory == 2)
            {
                if (czy3 == true)
                {
                    scianaZagGor.transform.Translate(Vector2.up * speed);

                }
                else
                {
                    scianaZagGor.transform.Translate(-Vector2.up * speed);

                }
                
            }
        }
        ktory++;
        if(ktory == 3)
        {
            ktory = 1;
        }
    }
}
