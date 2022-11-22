using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTracker : MonoBehaviour
{
    
    const float SCROLL = .10F;
    //const float SPEEDSCROLL = .50F
    private float scrolldist;
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

    [SerializeField] GameObject map;
    [SerializeField] GameObject[] squareBoundary;
    [SerializeField] GameObject[] uSlantBoundary;
    [SerializeField] GameObject[] dSlantBoundary;
    [SerializeField] GameObject[] buildingEntrance;
    
    [SerializeField] GameObject PauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0F;
        map = GameObject.FindWithTag("map");
        squareBoundary = GameObject.FindGameObjectsWithTag("SquareBoundary");
        uSlantBoundary = GameObject.FindGameObjectsWithTag("USlantBoundary");
        dSlantBoundary = GameObject.FindGameObjectsWithTag("DSlantBoundary");
        buildingEntrance = GameObject.FindGameObjectsWithTag("BuildingEntrance");

        direction = 0;
        scrolldist = 0;

        GameObject controller = GameObject.FindWithTag("GameController");

        scrolldist += controller.GetComponent<RespawnLocation>().getXOffset();
        scrollX();

        scrolldist = 0;
        scrolldist += controller.GetComponent<RespawnLocation>().getYOffset();
        scrollY();

        //controller.GetComponent<RespawnLocation>().setXOffset(0);
        //controller.GetComponent<RespawnLocation>().setYOffset(0);

        scrolldist = SCROLL;
    }

    // Update is called once per frame
    void Update()
    {
        hmovement = Input.GetAxis("Horizontal");
        vmovement = Input.GetAxis("Vertical");

       
        if (Input.GetKeyDown(KeyCode.P) && Time.timeScale != 0.0F)
        {
            Pause();
        }
        
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
            scrollX();
            return;
        }
        if (dir == LEFT && lockedMov[LEFT] == EMPTY)
        {
            if (scrolldist < 0)
            {
                flipScroll();
            }
            scrollX();
            return;
        }
        if (dir == UP && lockedMov[UP] == EMPTY)
        {
            if (scrolldist > 0)
            {
                flipScroll();
            }
            scrollY();
            return;
        }
        if (dir == DOWN && lockedMov[DOWN] == EMPTY)
        {
            if (scrolldist < 0)
            {
                flipScroll();
            }
            scrollY();
            return;
        }
    }

    // changes the sign of the scroll dist to make sure the screen scrolls in the correct direction
    private void flipScroll()
    {
        scrolldist = scrolldist * FLIP;
    }
    
    private void scrollX()
    {
        // scroll dist and send direction for tracking
        map.GetComponent<MapandBoxColliderScroll>().hScroll(scrolldist, direction);
        
        foreach(GameObject boundary in squareBoundary)
        {
            boundary.GetComponent<MapandBoxColliderScroll>().hScroll(scrolldist, direction);
        }
        
        foreach(GameObject dsBoundary in dSlantBoundary)
        {
            dsBoundary.GetComponent<DownSlant>().hScroll(scrolldist, direction);
        }

        
        foreach(GameObject usBoundary in uSlantBoundary)
        {
            usBoundary.GetComponent<UpSlant>().hScroll(scrolldist, direction);
        }

        foreach(GameObject bEntrance in buildingEntrance)
        {
            bEntrance.GetComponent<BuildingEntranceZone>().hScroll(scrolldist);
        }
    }

    private void scrollY()
    {
        // scroll dist and send direction for tracking
        map.GetComponent<MapandBoxColliderScroll>().vScroll(scrolldist, direction);

        
        foreach(GameObject boundary in squareBoundary)
        {
            boundary.GetComponent<MapandBoxColliderScroll>().vScroll(scrolldist, direction);
        }

        
        foreach(GameObject dsBoundary in dSlantBoundary)
        {
            dsBoundary.GetComponent<DownSlant>().vScroll(scrolldist, direction);
        }

        
        foreach(GameObject usBoundary in uSlantBoundary)
        {
            usBoundary.GetComponent<UpSlant>().vScroll(scrolldist, direction);
        }

        foreach(GameObject bEntrance in buildingEntrance)
        {
            bEntrance.GetComponent<BuildingEntranceZone>().vScroll(scrolldist);
        }
    }
    

    void Pause()
    {
        Vector2 pos = new Vector2(558.8197F, 274.1418F);
        Instantiate(PauseMenu, pos, Quaternion.identity);
        Time.timeScale = 0.0F;
    }

    

}
