using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTracker : MonoBehaviour
{
    
    const float SCROLL = .10F;
    //const float SPEEDSCROLL = .50F
    private float scrolldist = SCROLL;
    private float hmovement;
    private float vmovement;
    const int FLIP = -1;
    private float max;

    //const bool LOCK = false;
    //const bool UNLOCK = true;
    const int ADD = 1;
    const int REMOVE = -1;
    const int EMPTY = 0;
    //private bool[] canMove = new bool[5];
    private int[] lockedMov = new int[5];

    private int direction;

    const int IDLE = 0;
    const int UP = 1;
    const int DOWN = 2;
    const int RIGHT = 3;
    const int LEFT = 4;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < lockedMov.Length; i++)
        {
            lockedMov[i] = EMPTY;
        }
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

    // 
    public void lockDir(int dir)
    {
        lockedMov[dir] += ADD;
    }

    public void unlockDir(int dir)
    {
        lockedMov[dir] += REMOVE;
    }

    // calculates the absolute value of x
    float abs(float x)
    {
        if (x < 0)
        {
            x = -x;
        }
        return x;
    }// abs()

    // validates that we can scroll in the direction and then scrolls
    private void scroll(int dir)
    {
        direction = dir;
        if (dir == RIGHT && lockedMov[RIGHT] == EMPTY)
        {
            if (scrolldist > 0)
            {
                flipScroll();
            }
            scrollX(scrolldist);
            return;
        }
        if (dir == LEFT && lockedMov[LEFT] == EMPTY)
        {
            if (scrolldist < 0)
            {
                flipScroll();
            }
            scrollX(scrolldist);
            return;
        }
        if (dir == UP && lockedMov[UP] == EMPTY)
        {
            if (scrolldist > 0)
            {
                flipScroll();
            }
            scrollY(scrolldist);
            return;
        }
        if (dir == DOWN && lockedMov[DOWN] == EMPTY)
        {
            if (scrolldist < 0)
            {
                flipScroll();
            }
            scrollY(scrolldist);
            return;
        }
    }

    // changes the sign of the scroll dist to make sure the screen scrolls in the correct direction
    private void flipScroll()
    {
        scrolldist = scrolldist * FLIP;
    }
    
    private void scrollX(float scrolldist)
    {
        // scroll dist and send direction for tracking
        GameObject.FindWithTag("map").GetComponent<MapandBoxColliderScroll>().hScroll(scrolldist, direction);

        GameObject[] SquareBoundary;
        SquareBoundary = GameObject.FindGameObjectsWithTag("SquareBoundary");
        foreach(GameObject boundary in SquareBoundary)
        {
            boundary.GetComponent<MapandBoxColliderScroll>().hScroll(scrolldist, direction);
        }

        GameObject[] dSlantBoundary;
        dSlantBoundary = GameObject.FindGameObjectsWithTag("DSlantBoundary");
        foreach(GameObject dsBoundary in dSlantBoundary)
        {
            dsBoundary.GetComponent<DownSlant>().hScroll(scrolldist, direction);
        }

        GameObject[] uSlantBoundary;
        uSlantBoundary = GameObject.FindGameObjectsWithTag("USlantBoundary");
        foreach(GameObject usBoundary in uSlantBoundary)
        {
            usBoundary.GetComponent<UpSlant>().hScroll(scrolldist, direction);
        }
    }

    private void scrollY(float scrolldist)
    {
        // scroll dist and send direction for tracking
        GameObject.FindWithTag("map").GetComponent<MapandBoxColliderScroll>().vScroll(scrolldist, direction);

        GameObject[] SquareBoundary;
        SquareBoundary = GameObject.FindGameObjectsWithTag("SquareBoundary");
        foreach(GameObject boundary in SquareBoundary)
        {
            boundary.GetComponent<MapandBoxColliderScroll>().vScroll(scrolldist, direction);
        }

        GameObject[] dSlantBoundary;
        dSlantBoundary = GameObject.FindGameObjectsWithTag("DSlantBoundary");
        foreach(GameObject dsBoundary in dSlantBoundary)
        {
            dsBoundary.GetComponent<DownSlant>().vScroll(scrolldist, direction);
        }

        GameObject[] uSlantBoundary;
        uSlantBoundary = GameObject.FindGameObjectsWithTag("USlantBoundary");
        foreach(GameObject usBoundary in uSlantBoundary)
        {
            usBoundary.GetComponent<UpSlant>().vScroll(scrolldist, direction);
        }
    }

}
