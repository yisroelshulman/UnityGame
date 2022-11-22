using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonBehavior : MonoBehaviour
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

    /// needs info
    public void Tutorial()
    {
        
    }

    public void SelectionMenu()
    {
        SceneManager.LoadScene("SelectionMenu");
    }
}
