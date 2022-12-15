using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskButtons : MonoBehaviour
{

    const int LEARNCENTR = 0;
    const int WOMENSCNTR = 1;
    const int MAGNRCNTR = 2;
    const int HEALTHCOUNCIL = 3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void back()
    {
        Destroy(gameObject);
    }

    public void LearningCenter()
    {
        PersistentData.Instance.CompleteTask(0);
    }

    public void WomensCenter()
    {
        PersistentData.Instance.CompleteTask(1);
    }

    public void MagnerCenter()
    {
        PersistentData.Instance.CompleteTask(2);
    }

    public void PersonalCouncil()
    {
        PersistentData.Instance.CompleteTask(3);
    }

    public void HealthClinic()
    {
        PersistentData.Instance.CompleteTask(4);
    }

    public void FoodPantry()
    {
        PersistentData.Instance.CompleteTask(5);
    }

    public void TechSupportWeb()
    {
        PersistentData.Instance.CompleteTask(6);
    }

    public void TechSupportLibrary()
    {
        PersistentData.Instance.CompleteTask(7);
    }

    public void Registrar()
    {
        PersistentData.Instance.CompleteTask(8);
    }

    public void FinancialAid()
    {
        PersistentData.Instance.CompleteTask(9);
    }
}
