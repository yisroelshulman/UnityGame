using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{

    public static ButtonControl Instance;

    private bool arrowKeys;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        arrowKeys = true;
    }

    public void setToArrowKeys()
    {
        arrowKeys = true;
    }

    public void setToWASD()
    {
        arrowKeys = false;
    }

    public bool getArrowKeys()
    {
        return arrowKeys;
    }
}
