using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;


public class Zadanie_1 : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    int objectCounter = 0;

    // ilosc obiektow
    public int IleObiektow;

    // obiekt do generowania
    public GameObject block;

    // pozycja x,z platformy
    float pozX;
    float pozZ;
    // skala platformy
    float skalaX;
    float skalaZ;

    //range x i z
    float rangeX1;
    float rangeX2;
    float rangeZ1;
    float rangeZ2;

    //losowy material
    public Material[] Materials;
    

    void Start()
    {
        pozX = transform.position.x;
        pozZ = transform.position.z;
        skalaX = transform.localScale.x;
        skalaZ = transform.localScale.z;
        //print("to jest skala " +skalaX + skalaZ);

        rangeX1 = pozX - (skalaX / 2) + 0.5f;
        rangeX2 = pozX + (skalaX / 2) - 0.5f;
        rangeZ1 = pozZ - (skalaZ / 2) + 0.5f;
        rangeZ2 = pozZ + (skalaZ / 2) - 0.5f;

        int xx1 = (int)Math.Ceiling(rangeX1);
        int xx2 = (int)Math.Ceiling(rangeX2);
        int zz1 = (int)Math.Ceiling(rangeZ1);
        int zz2 = (int)Math.Ceiling(rangeZ2);
        //print(" liczby z range " + xx1 + " " + xx2 + " " + zz1 + " " + zz2 + " " );

        // w momecie uruchomienia generuje 10 kostek w losowych miejscach
        List<int> pozycje_x = new List<int>(Enumerable.Range(xx1, xx2).OrderBy(x => Guid.NewGuid()).Take(IleObiektow));
        List<int> pozycje_z = new List<int>(Enumerable.Range(zz1, zz2).OrderBy(x => Guid.NewGuid()).Take(IleObiektow));

        for (int i = 0; i < IleObiektow; i++)
        {
            this.positions.Insert(i, new Vector3(pozycje_x[i], 5, pozycje_z[i]));
        }
        foreach (Vector3 elem in positions)
        {
            Debug.Log(elem);
        }
        // uruchamiamy coroutine
        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt()
    {
        Debug.Log("wywo�ano coroutine");
        foreach (Vector3 pos in positions)
        {
            //dodajemy material do cube
            block.GetComponent<Renderer>().material = Materials[Random.Range(0, Materials.Length)];

            Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            yield return new WaitForSeconds(this.delay);
        }
        // zatrzymujemy coroutine
        StopCoroutine(GenerujObiekt());
    }
}


