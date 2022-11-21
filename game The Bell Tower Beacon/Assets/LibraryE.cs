using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LibraryE : MonoBehaviour
{
    private bool canEnter;
    // Start is called before the first frame update
    void Start()
    {
        canEnter = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (canEnter && Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)) {
            Debug.Log("WE ENTER THE LIBRARY");
            SceneManager.LoadScene("Library");
        }
    }

    void OnTriggerEnter2D(Collider2D colldier) {
        canEnter = true;
    }
    void OnTriggerExit2D(Collider2D colldier) {
        canEnter = false;
    }
}
