using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadMenuButtonBehavior : MonoBehaviour
{
    [SerializeField] GameObject buttonCanvas;
    [SerializeField] GameObject playerNameInput;
    [SerializeField] GameObject message;

    // Start is called before the first frame update
    void Start()
    {
        if (buttonCanvas == null)
        {
            buttonCanvas = GameObject.FindWithTag("ButtonCanvas");
            ButtonBack();
        }
        message.SetActive(false);
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
        string s = playerNameInput.GetComponent<TMP_InputField>().text;
        if (string.IsNullOrEmpty(s))
        {
            message.SetActive(true);
            return;
        }
        PersistentData.Instance.SetPlayerName(s);
        SceneManager.LoadScene("Campusv2BetterMovementLogic");
    }

    public void HighScores()
    {
        string s = playerNameInput.GetComponent<TMP_InputField>().text;
        if (string.IsNullOrEmpty(s))
        {
            message.SetActive(true);
            return;
        }
        PersistentData.Instance.SetPlayerName(s);
        SceneManager.LoadScene("HighScores");
    }
}
