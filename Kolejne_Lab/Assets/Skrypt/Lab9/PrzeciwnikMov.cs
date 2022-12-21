
using UnityEngine.SceneManagement;
using UnityEngine;

public class PrzeciwnikMov : MonoBehaviour
{
    public PrzeciwnikController2D controller;
    public Animator animator;
    public float runSpeed = 3f;
    bool jump = false;
    float horizontalMove = 0f;

    //poruszanie sie
    public GameObject[] waypoints;
    int aktualny = 0;
    float nowy = 1;
    private GameObject przeciwni;
    public bool czyGoni = true;

    private void Start()
    {
        przeciwni = GameObject.Find("Przeciwnik");
        przeciwni.GetComponent<PrzeciwnikController2D>().Flip();
    }

    void Update()
    {
        if (czyGoni == true)
        {
            if (Vector2.Distance(waypoints[aktualny].transform.position, transform.position) < nowy)
            {
                aktualny++;

                if (aktualny >= waypoints.Length)
                {
                    aktualny = 0;
                }
                przeciwni.GetComponent<PrzeciwnikController2D>().Flip();
            }
            transform.position = Vector2.MoveTowards(transform.position, waypoints[aktualny].transform.position, Time.deltaTime * runSpeed);

            animator.SetFloat("Speed2", Mathf.Abs(horizontalMove));
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
    }

    public void OnLanding()
    {
        Debug.Log("OnLanding()");
    }
}
