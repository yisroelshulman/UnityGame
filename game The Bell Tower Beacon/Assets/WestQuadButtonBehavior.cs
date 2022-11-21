using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WestQuadButtonBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GetNewTask()
    {

    }

    public void CompleteTask()
    {
        
    }

    public void ExitWestQuad()
    {
        GameObject.FindWithTag("GameController").GetComponent<RespawnLocation>().setXOffset(31.7F);
        GameObject.FindWithTag("GameController").GetComponent<RespawnLocation>().setYOffset(-1.9F);
        SceneManager.LoadScene("Campusv2BetterMovementLogic");
    }
}
