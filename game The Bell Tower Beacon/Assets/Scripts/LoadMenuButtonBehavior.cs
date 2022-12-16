using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LoadMenuButtonBehavior : MonoBehaviour
{
    [SerializeField] GameObject VolumeCanvas;
    [SerializeField] GameObject playerNameInput;
    [SerializeField] GameObject message;

    [SerializeField] Toggle t1;
    [SerializeField] Toggle t2;
    [SerializeField] Toggle t3;

    const int FULL = 0;
    const int TASK = 1;
    const int EXAM = 2;

    // Start is called before the first frame update
    void Start()
    {
        if (VolumeCanvas == null)
        {
            VolumeCanvas = GameObject.FindWithTag("ButtonCanvas");
        }
        ButtonBack();
        message.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// Needs functionality
    public void Buttons()
    {
        VolumeCanvas.SetActive(true);
    }

    public void ButtonBack()
    {
        VolumeCanvas.SetActive(false);
    }

    public void StartGame()
    {
        Toggle();
        string s = playerNameInput.GetComponent<TMP_InputField>().text;
        if (string.IsNullOrEmpty(s))
        {
            message.SetActive(true);
            return;
        }
        PersistentData.Instance.SetPlayerName(s);
        int mode = PersistentData.Instance.GetMode();

        if (mode == EXAM)
        {
            SceneManager.LoadScene("FinalExam");
        }
        else
        {
            SceneManager.LoadScene("Campusv2BetterMovementLogic");
        }
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

    private void Toggle()
    {
        if (t1.isOn)
        {
            PersistentData.Instance.SetMode(FULL);
        }
        if (t2.isOn)
        {
            PersistentData.Instance.SetMode(TASK);
        }
        if (t3.isOn)
        {
            PersistentData.Instance.SetMode(EXAM);
        }
    }
}
