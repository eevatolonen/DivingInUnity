using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HandlePlayerMovement();
    }

    private void HandlePlayerMovement()
    {
        /* Input class is easy way to access player input from mouse/keyboard/controller
        * THE AMOUNT VARIES FROM -1 TO  1!!!!! Easy to make player go backward/forward, left/right
        */

        // get's player's horizontal input (presses of a and d) and gives it a value between -1 and 1
        horizontalInput = Input.GetAxis("Horizontal");

        // get's player's vertical input (presses of s and w) and gives it a value between -1 and 1
        forwardInput = Input.GetAxis("Vertical");

        // when multiplied with Time.deltatime, the vehicle moves 1 unit per second, so in order to increase speed we multiply with preferred number
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // by changing turnspeed between -1 and 1, we get the player to turn either left (-1) or right (1)
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
