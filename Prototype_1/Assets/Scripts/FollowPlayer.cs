using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    private float offset_height = 5;
    private float offset_distance = -7;
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, offset_height, offset_distance);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
