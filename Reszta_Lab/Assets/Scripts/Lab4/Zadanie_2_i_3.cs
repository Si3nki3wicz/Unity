using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class Zadanie_2_i_3 : MonoBehaviour
{
    public float speed = 3;
    public float rotationSpeed = 90;
    public float gravity = -20f;
    public float jumpSpeed = 15;

    CharacterController characterController;
    Vector3 moveVelocity;
    Vector3 turnVelocity;

    //kamera za graczem
    public Transform camTarget;
    public float pLerp = .02f;
    public float rLerp = .01f;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        var hInput = Input.GetAxis("Horizontal");
        var vInput = Input.GetAxis("Vertical");

        if (characterController.isGrounded)
        {
            moveVelocity = transform.forward * speed * vInput;
            turnVelocity = transform.up * rotationSpeed * hInput;
            if (Input.GetButtonDown("Jump"))
            {
                moveVelocity.y = jumpSpeed;
            }
        }

        //Grawitacja
        moveVelocity.y += gravity * Time.deltaTime;
        characterController.Move(moveVelocity * Time.deltaTime);
        transform.Rotate(turnVelocity * Time.deltaTime);

        //transform.position = Vector3.Lerp(transform.position, camTarget.position, pLerp);
        //transform.rotation = Quaternion.Lerp(transform.rotation, camTarget.rotation, rLerp);

    }
}