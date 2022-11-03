using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab4_Zad4 : MonoBehaviour
{
    // ruch wokó³ osi Y bêdzie wykonywany na obiekcie gracza, wiêc
    // potrzebna nam referencja do niego (konkretnie jego komponentu Transform)

    public float speedV = 2.0f;
    public float speedH = 2.0f;

    private float rotationX = 0.0f;
    private float rotationY = 0.0f;

    private float minValue = -90f;
    private float maxValue = 90f;

    void Start()
    {
        // zablokowanie kursora na œrodku ekranu, oraz ukrycie kursora
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // pobieramy wartoœci dla obu osi ruchu myszy
        rotationY += speedV * Input.GetAxis("Mouse X");
        rotationX -= speedH * Input.GetAxis("Mouse Y");

        // ograniczenie kamery
        rotationX = Mathf.Clamp(rotationX, minValue, maxValue);

        transform.eulerAngles = new Vector3(rotationX, rotationY, 0);

    }
}
