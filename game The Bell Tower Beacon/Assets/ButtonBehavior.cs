using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
///using UnityEngine.UI;

public class ButtonBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// needs info
    public void Rules()
    {
        
    }

    /// Needs funbctionality
    public void Buttons()
    {

    }

    /// needs info
    public void Tutorial()
    {
        
    }

    public void SelectionMenu()
    {
        SceneManager.LoadScene("SelectionMenu");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Campusv2BetterMovementLogic");
    }

    public void ExitWestQuad()
    {
        GameObject.FindWithTag("GameController").GetComponent<RespawnLocation>().setXOffset(31.7F);
        GameObject.FindWithTag("GameController").GetComponent<RespawnLocation>().setYOffset(-1.9F);
        SceneManager.LoadScene("Campusv2BetterMovementLogic");
    }

}
