using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuOptions : MonoBehaviour
{
    [SerializeField] GameObject buttonCanvas;
    [SerializeField] GameObject PauseMenu;

    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        buttonCanvas = GameObject.FindWithTag("ButtonCanvas");
        ButtonBack();        
        PauseMenu = GameObject.FindWithTag("Pause");
        Unpause();
        
    }

    void update()
    {
        Debug.Log("test");
        
    }

    public bool getIsPaused()
    {
        return isPaused;
    }
   

    /// Needs functionality
    public void Buttons()
    {
        buttonCanvas.SetActive(true);
    }

    public void ButtonBack()
    {
        buttonCanvas.SetActive(false);
    }

    public void Pause()
    {
        PauseMenu.SetActive(true);
        isPaused = true;
    }

    public void Unpause()
    {
        PauseMenu.SetActive(false);
        isPaused = false;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
