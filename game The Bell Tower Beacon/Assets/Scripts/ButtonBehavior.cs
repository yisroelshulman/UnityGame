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

    public void ExitToEastQuad() {
        GameObject.FindWithTag("GameController").GetComponent<RespawnLocation>().setXOffset(-38.8f);
        GameObject.FindWithTag("GameController").GetComponent<RespawnLocation>().setYOffset(-2.8F);
        SceneManager.LoadScene("Campusv2BetterMovementLogic");
    }

}
