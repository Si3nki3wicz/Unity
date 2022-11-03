using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie_5 : MonoBehaviour
{
    public GameObject block;
    public int generuj_ile = 10;
    int losX;
    int losZ;
    int losY;

    void Start()
    {

        List<int> listX = new List<int>();
        List<int> listZ = new List<int>();

        while(listX.Count != generuj_ile)
        {
            losX = Random.Range(-5, 5);
            
            if (!listX.Contains(losX))
            {          
                listX.Add(losX);
            }       
        }
        while (listZ.Count != generuj_ile)
        {
            losZ = Random.Range(-5, 5);
            
            if (!listZ.Contains(losZ))
            {
                listZ.Add(losZ);
            }
        }

        for (int i  = 0; i < generuj_ile; i++)
        {
            losY = Random.Range(1, 3);
            Instantiate(block, new Vector3(listX[i], losY, listZ[i]), Quaternion.identity);
        }

        /* Sprawdza jakie liczby
        string result = "ListX contents: ";
        foreach (var item in listX)
        {
            result += item.ToString() + ", ";
        }
        Debug.Log(result);

        string result1 = "ListZ contents: ";
        foreach (var item1 in listZ)
        {
            result1 += item1.ToString() + ", ";
        }
        Debug.Log(result1);
        */
    }

    // Update is called once per frame
    void Update()
    {

    }
}

