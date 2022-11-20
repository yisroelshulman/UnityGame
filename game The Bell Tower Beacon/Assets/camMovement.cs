using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMovement : MonoBehaviour
{
    public GameObject cam;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        cam = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = player.position.x - 1;
        float y = player.position.y;
        float z = player.position.z;
        cam.transform.position = new Vector3(x, y, z);
    }

}