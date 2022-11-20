using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    public Transform player;
    public GameObject cam;

    [SerializeField] float hmovement;
    [SerializeField] float vmovement;
    const float SCROLL = 1.0F;
    [SerializeField] float scrolldist = SCROLL;
    [SerializeField] int max;

    const int FLIP = -1;
    public int direction;
    const int IDLE = 0;
    const int UP = 1;
    const int DOWN = 2;
    const int RIGHT = 3;
    const int LEFT = 4;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        cam = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        hmovement = Input.GetAxis("Horizontal");
        vmovement = Input.GetAxis("Vertical");

        if(abs(hmovement) == 1 || abs(vmovement) == 1)
        {
            max = 1;
        }
        
        if (max == 1 && vmovement == 0 && hmovement == 0)
        {
            max = 0;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {       
        if (hmovement !=0 || vmovement !=0)
        {
            if (hmovement == 0 && abs(vmovement) >= max)
            {
                if (vmovement > 0)
                {
                    scroll(UP);
                }
                else if (vmovement < 0)
                {
                    scroll(DOWN);
                }
            }
            if (vmovement == 0 && abs(hmovement) >= max)
            {
                if (hmovement > 0)
                {
                    scroll(RIGHT);
                }
                else if (hmovement < 0)
                {
                    scroll(LEFT);
                }
            }

        }
    }

    private void scroll(int dir)
    {
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;
        switch (dir)
        {
            case UP:
                if (scrolldist > 0)
                {
                    flipScroll();
                }
                y = y + scrolldist;
                break;
            case DOWN:
                if (scrolldist < 0)
                {
                    flipScroll();
                }
                y = y + scrolldist;
                break;
            case RIGHT:
                if (scrolldist > 0)
                {
                    flipScroll();
                }
                x = x + scrolldist;
                break;
            case LEFT:
                if (scrolldist < 0)
                {
                    flipScroll();
                }
                x = x + scrolldist;
                break;
            default:
                break;
        }
        direction = dir;
        player.position = new Vector3(x, y, z);
        //cam.transform.position = player.position;
    }

    private void flipScroll()
    {
        scrolldist = scrolldist * FLIP;
    }

    float abs(float x)
    {
        if (x < 0)
        {
            x = -x;
        }
        return x;
    }

}
