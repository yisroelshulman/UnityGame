using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownSlant : MonoBehaviour
{
    private int direction;
    private int lastdir;

    const int UP = 1;
    const int DOWN = 2;
    const int RIGHT = 3;
    const int LEFT = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // scroll the screen horizontally by scrolldist
    public void hScroll(float scrolldist, int dir)
    {
        direction = dir;
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;
        transform.position = new Vector3(x + scrolldist, y, z);
    }// hScroll()

    // scroll the screen vertically by scrolldist
    public void vScroll(float scrolldist, int dir)
    {
        direction = dir;
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;
        transform.position = new Vector3(x, y + scrolldist, z);
    }// vScroll()

    // checks for player collision and then locks the scroll in that direction
    void OnCollisionEnter2D (Collision2D collision)
	{
        if (collision.gameObject.tag == "Player")
        {
            lastdir = direction;
            if (lastdir == UP || lastdir == RIGHT)
            {
                GameObject.FindWithTag("Player").GetComponent<MovementTracker>().lockDir(UP);
                GameObject.FindWithTag("Player").GetComponent<MovementTracker>().lockDir(RIGHT);
                return;
            }
            if (lastdir == DOWN || lastdir == LEFT)
            {
                GameObject.FindWithTag("Player").GetComponent<MovementTracker>().lockDir(DOWN);
                GameObject.FindWithTag("Player").GetComponent<MovementTracker>().lockDir(LEFT);
                return;
            }
        }
	}// OnCollisionEnter2D()

    // checks for player ending collision then unlocks the scroll
    void OnCollisionExit2D (Collision2D collision)
	{
        if (collision.gameObject.tag == "Player")
        {
            if (lastdir == UP || lastdir == RIGHT)
            {
                GameObject.FindWithTag("Player").GetComponent<MovementTracker>().unlockDir(UP);
                GameObject.FindWithTag("Player").GetComponent<MovementTracker>().unlockDir(RIGHT);
            }
            if (lastdir == DOWN || lastdir == LEFT)
            {
                GameObject.FindWithTag("Player").GetComponent<MovementTracker>().unlockDir(DOWN);
                GameObject.FindWithTag("Player").GetComponent<MovementTracker>().unlockDir(LEFT);
            }
            lastdir = 0;
        }
	}// OnCollisionExit2D()
}
