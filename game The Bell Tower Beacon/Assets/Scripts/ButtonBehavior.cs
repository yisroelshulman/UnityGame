using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
///using UnityEngine.UI;

public class ButtonBehavior : MonoBehaviour
{
    
    [SerializeField] GameObject TaskPanel;
    
    // Start is called before the first frame update
    void Start()
    {        
    }

    // Update is called once per frame
    void Update()
    {        
    }    

    public void Back()
    {
        GameObject.FindGameObjectWithTag("GameController").GetComponent<WasteTime>().Back();
    }

    public void RulesBack()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GetTask()
    {
        PersistentData.Instance.GetTask();
        Vector2 pos = new Vector2(558.8197F, 274.1418F);
        Instantiate(TaskPanel, pos, Quaternion.identity);
    }

    public void Viewtask()
    {

    }

    public void ZoomIn()
    {

    }

    public void ZoomOut()
    {
        
    }

}
