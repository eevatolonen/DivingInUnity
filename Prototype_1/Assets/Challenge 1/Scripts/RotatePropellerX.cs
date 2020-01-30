using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropellerX : MonoBehaviour
{
    // Start is called before the first frame update
    private float propellingSpeed = 10.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // rotates the propeller of the plane
        transform.Rotate(0, 0, propellingSpeed);
    }
}
