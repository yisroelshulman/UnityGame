using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] float hmovement = 0;
    [SerializeField] float vmovement = 0;
    [SerializeField] int speed = 1;
    [SerializeField] float nomovement = 0;

    public GameObject cam;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        if (rigid == null)
        {
            rigid = GetComponent<Rigidbody2D>();
        }
        cam = GameObject.FindWithTag("MainCamera");
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        hmovement = Input.GetAxis("Horizontal");
        vmovement = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        //test
        if (hmovement !=0 || vmovement !=0)
        {
            if (hmovement == 0)
            {
                rigid.velocity = new Vector2(nomovement, vmovement);
            }
            if (vmovement == 0)
            {
                rigid.velocity = new Vector2(hmovement, nomovement);
            }

        }
        else
        {
            rigid.velocity = new Vector2(0, 0);
        }
    }
}
