using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuOptions : MonoBehaviour
{
    [SerializeField] GameObject volume;

    // Start is called before the first frame update
    void Start()
    {
        volume = GameObject.FindWithTag("ButtonCanvas");
        ButtonBack();
    }

    void update()
    {
        Debug.Log("test");
    }

    /// Needs functionality
    public void Buttons()
    {
        volume.SetActive(true);
    }

    public void ButtonBack()
    {
        volume.SetActive(false);
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
