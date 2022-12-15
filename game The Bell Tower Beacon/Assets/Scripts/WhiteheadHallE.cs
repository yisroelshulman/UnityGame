using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WhiteheadHallE : MonoBehaviour
{
    private bool detect;


    // Start is called before the first frame update
    void Start()
    {
        detect = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (detect && (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)))
        {
            SceneManager.LoadScene("WhiteheadHall");
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        detect = true;
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        detect = false;
    }
}