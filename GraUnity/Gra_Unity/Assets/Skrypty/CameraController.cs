using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float speed = 0.5f;
    private float currentPosy;
    private float currentPosx;
    private Vector3 velocity = Vector3.zero;

    private void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPosx, currentPosy, transform.position.z),
            ref velocity, speed);
    }
    public void MoveToNewRoom(Transform newRoom)
    {
        currentPosy = newRoom.position.y;
        currentPosx = newRoom.position.x;
    }
}
