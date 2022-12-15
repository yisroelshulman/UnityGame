using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// controlls the scroll of the entrance zones
public class BuildingEntranceZone : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // scroll the screen horizontally by scrolldist
    public void hScroll(float scrolldist)
    {
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;
        transform.position = new Vector3(x + scrolldist, y, z);
    }// hScroll()

    // scroll the screen vertically by scrolldist
    public void vScroll(float scrolldist)
    {
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;
        transform.position = new Vector3(x, y + scrolldist, z);
    }// vScroll()

   

   
}
