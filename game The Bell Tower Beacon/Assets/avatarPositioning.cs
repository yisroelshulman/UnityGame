using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avatarPositioning : MonoBehaviour
{
    public Transform player;
    const float ONE = 1;
    const float ZERO = 0;

    

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        player.position = new Vector3(ONE, ONE, ZERO);
        player.rotation = new Quaternion(ZERO, ZERO, ZERO, ONE);
       
    }
}
