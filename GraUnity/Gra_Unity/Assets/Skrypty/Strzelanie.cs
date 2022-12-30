using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strzelanie : MonoBehaviour
{
    public Transform firePoint;
    public Transform firePointGdzie;
    public GameObject bulletPref;

    public float bulletforce = 20f;

    public bool canFire;
    public float timer = 0;
    public float timeBetweenFiring = 60;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!canFire)
        {
            
            if(timer > timeBetweenFiring)
            {
                canFire = true;
                timer = 0;
            }
            timer++;
        }

        if (Input.GetMouseButton(0) && canFire)
        {
            canFire = false;
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPref, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletforce, ForceMode2D.Impulse);
    }
}
