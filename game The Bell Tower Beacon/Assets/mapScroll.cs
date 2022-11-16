using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapScroll : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] GameObject map;
    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player").transform;
        }
        if (map == null)
        {
            map = GameObject.FindWithTag("map");
        }
    }

    // Update is called once per frame
    void Update()
    {
        map.transform.position = player.transform.position;
    }
}
