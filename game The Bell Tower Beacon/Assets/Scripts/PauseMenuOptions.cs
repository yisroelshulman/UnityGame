using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuOptions : MonoBehaviour
{
    [SerializeField] GameObject buttonCanvas;
    [SerializeField] GameObject PauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        buttonCanvas = GameObject.FindWithTag("ButtonCanvas");
        ButtonBack();
    }

    void update()
    {
        Debug.Log("test");
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
    }

    public void Unpause()
    {        
        Time.timeScale = 1.0F;
        Destroy(gameObject);
    }

    public void MainMenu()
    {
        PersistentData.Instance.Reset();
        SceneManager.LoadScene("MainMenu");
    }
}
