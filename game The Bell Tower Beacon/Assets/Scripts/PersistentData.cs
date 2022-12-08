using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentData : MonoBehaviour
{

    [SerializeField] static float xOffset;
    [SerializeField] static float yOffset;


    public static PersistentData Instance;

    public void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
        }
        else
            Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        xOffset = 0;
        yOffset = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float getXOffset()
    {
        return xOffset;
    }

    public float getYOffset()
    {
        return yOffset;
    }

    public void setXOffset(float x)
    {
        xOffset = x;
    }

    public void setYOffset(float y)
    {
        yOffset = y;
    }

}
