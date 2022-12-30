using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zamykanie : MonoBehaviour
{
    public GameObject Drzwi1;
    public GameObject Drzwi2;
    public int ilePrzeciwnikow = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ilePrzeciwnikow > 0)
        {
            Drzwi1.GetComponent<BoxCollider2D>().isTrigger = false;
            Drzwi1.GetComponent<Drzwi>().czy_mozna = false;
            
        }
        else
        {
            Drzwi1.GetComponent<BoxCollider2D>().isTrigger = true;
            Drzwi1.GetComponent<Drzwi>().czy_mozna = true;
            
        }

        if (ilePrzeciwnikow > 0)
        {
            Drzwi2.GetComponent<BoxCollider2D>().isTrigger = false;
            
            Drzwi2.GetComponent<Drzwi2>().czy_mozna = false;
        }
        else
        {
            Drzwi2.GetComponent<BoxCollider2D>().isTrigger = true;
            
            Drzwi2.GetComponent<Drzwi2>().czy_mozna = true;
        }
    }
}
