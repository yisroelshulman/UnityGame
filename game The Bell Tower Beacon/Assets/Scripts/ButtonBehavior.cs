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

    public void Back()
    {
        GameObject.FindGameObjectWithTag("GameController").GetComponent<WasteTime>().Back();
    }

    public void RulesBack()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
