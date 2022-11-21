using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenuButtonBehavior : MonoBehaviour
{
    [SerializeField] static GameObject buttonCanvas;

    // Start is called before the first frame update
    void Start()
    {
        if (buttonCanvas == null)
        {
            buttonCanvas = GameObject.FindWithTag("ButtonCanvas");
            ButtonBack();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
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

    public void StartGame()
    {
        SceneManager.LoadScene("Campusv2BetterMovementLogic");
    }
}
