using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenScroll : MonoBehaviour
{
    public float length, height;
    const float SCROLL = 1.0F;
    private float scrolldist = SCROLL;
    public float hmovement;
    public float vmovement;
    const int FLIP = -1;
    private float max;
    public bool canMoveUp = true;
    public bool canMoveDown = true;
    public bool canMoveRight = true;
    public bool canMoveLeft = true;
    public int direction;
    const int IDLE = 0;
    const int UP = 1;
    const int DOWN = 2;
    const int RIGHT = 3;
    const int LEFT = 4;
    public int lastdir;
    // Start is called before the first frame update
    void Start()
    {
        height = GetComponent<SpriteRenderer>().bounds.size.y;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
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
                if (canMoveUp)
                {
                    if (scrolldist > 0)
                    {
                        flipScroll();
                    }
                    y = y + scrolldist;
                }
                break;
            case DOWN:
                if (canMoveDown)
                {
                    if (scrolldist < 0)
                    {
                        flipScroll();
                    }
                    y = y + scrolldist;
                }
                break;
            case RIGHT:
                if (canMoveRight)
                {
                    if (scrolldist > 0)
                    {
                        flipScroll();
                    }
                    x = x + scrolldist;
                }
                break;
            case LEFT:
                if (canMoveLeft)
                {
                    if (scrolldist < 0)
                    {
                        flipScroll();
                    }
                    x = x + scrolldist;
                }
                break;
            default:
                break;
        }
        direction = dir;
        transform.position = new Vector3(x, y, z);
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

    public void flipMoveDir(int dir)
    {
        switch (dir)
        {
            case UP:
                canMoveUp = !canMoveUp;
                break;
            case DOWN:
                canMoveDown = !canMoveDown;
                break;
            case RIGHT:
                canMoveRight = !canMoveRight;
                break;
            case LEFT:
                canMoveLeft = !canMoveLeft;
                break;
            default:
                break;
        }
    }

    void OnCollisionEnter2D (Collision2D collision)
	{
        lastdir = direction;
        if (collision.gameObject.tag == "Player")
        {
            lockUnlockScroll(lastdir);
        }
	}

   void OnCollisionExit2D (Collision2D collision)
	{
        if (collision.gameObject.tag == "Player")
        {
            lockUnlockScroll(lastdir);
            lastdir = 0;
        }
	}

    void lockUnlockScroll(int dir)
    {
        GameObject.FindWithTag("map").GetComponent<ScreenScroll>().flipMoveDir(lastdir);

        GameObject[] boundaries;
        boundaries = GameObject.FindGameObjectsWithTag("Boundry");
        foreach(GameObject boundry in boundaries)
        {
            boundry.GetComponent<ScreenScroll>().flipMoveDir(lastdir);
        }
    }
}
