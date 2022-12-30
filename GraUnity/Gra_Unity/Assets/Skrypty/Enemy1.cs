using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    public Rigidbody2D rb;
    Transform target;
    Vector2 moveDirection;

    //1hp = 3int //jednak nie
    public int health = 10;

    GameObject Zamke;
    


    private void Start()
    {
        GameObject gameObject1 = GameObject.FindWithTag("Player");
        target = gameObject1.transform;

        Zamke = GameObject.Find("ZamykanieDrzwi");
        
    }

    
    private void Update()
    {
        if (target)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            rb.rotation = angle;
            moveDirection = direction;
        }
    }

    private void FixedUpdate()
    {
        if (target)
        {
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * moveSpeed;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            health--;
            if (health == 0)
            {
                Destroy(gameObject);
                Zamke.GetComponent<Zamykanie>().ilePrzeciwnikow -= 1;
            }
        }
            
    }
}
