using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie6_Mathlerp : MonoBehaviour
{
    // animate the game object from -1 to +1 and back
    public float minimum = 3.0F;
    public float maximum = 9.0F;
    public float speed = 5.0f;
    public float target_positionX = 4;
    public float target_positionZ = 0;

    // starting value for the Lerp
    static float t = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // animate the position of the game object...
        transform.position = new Vector3(target_positionX, Mathf.Lerp(minimum, maximum, t), target_positionZ);

        // .. and increase the t interpolater
        t += 0.5f * speed *Time.deltaTime;

        // now check if the interpolator has reached 1.0
        // and swap maximum and minimum so game object moves
        // in the opposite direction.
        if (t > 3.0f)
        {
            float temp = maximum;
            maximum = minimum;
            minimum = temp;
            t = 0.0f;
        }
    }
}
