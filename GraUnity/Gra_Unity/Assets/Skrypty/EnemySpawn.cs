using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    //enemyspawn
    public Transform EnemyPoint;
    public Transform EnemyPoint2;
    public Transform EnemyPoint3;
    public GameObject EnemyPref;

    GameObject Zamke;
    // Start is called before the first frame update
    void Start()
    {
        Zamke = GameObject.Find("ZamykanieDrzwi");
    }


    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Zagadka")
        {
            GameObject newEnemy = Instantiate(EnemyPref, EnemyPoint.position, EnemyPoint.rotation);
            Zamke.GetComponent<Zamykanie>().ilePrzeciwnikow += 1;
            GameObject newEnemy1 = Instantiate(EnemyPref, EnemyPoint2.position, EnemyPoint2.rotation);
            Zamke.GetComponent<Zamykanie>().ilePrzeciwnikow += 1;
            GameObject newEnemy2 = Instantiate(EnemyPref, EnemyPoint3.position, EnemyPoint3.rotation);
            Zamke.GetComponent<Zamykanie>().ilePrzeciwnikow += 1;
            Destroy(gameObject);

        }
    }
    
}
