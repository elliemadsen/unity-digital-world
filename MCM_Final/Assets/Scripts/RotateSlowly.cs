using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSlowly : MonoBehaviour
{
    // User inputs
    public int degRotatePerSecond = 5;
    public float amplitudeFloating = 0.5f;
    public float frequencyFloating = 1f;

    //Varibles storing position
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    void Start()
    {
        posOffset = transform.position;
    }

    void Update()
    {

     // Rotate gameobject in Y axis
        transform.Rotate(new Vector3(0, degRotatePerSecond, 0) * Time.deltaTime);

        // Float gameobject up/down with Sin()
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequencyFloating) * amplitudeFloating;

        transform.position = tempPos;
    }
}
