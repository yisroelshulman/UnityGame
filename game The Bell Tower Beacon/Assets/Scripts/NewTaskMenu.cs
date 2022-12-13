using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewTaskMenu : MonoBehaviour
{

    [SerializeField] TMP_Text task;

    // Start is called before the first frame update
    void Start()
    {
        Display();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Display()
    {
        task.text = PersistentData.Instance.GetCurrentTask();
    }
}
