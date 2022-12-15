using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class InGameTime : MonoBehaviour
{
    [SerializeField] TMP_Text time;
    [SerializeField] TMP_Text tasks;
    bool isTimeSet;
    bool isTaskActive;
    int startHour;
    int startMinute;
    int startSecond;
    int totalSeconds;

    const int SECINMIN = 60;
    const int SECINHR = SECINMIN * 60;
    const int MININHR = 60;
    

    // Start is called before the first frame update
    void Start()
    {
        isTimeSet = PersistentData.Instance.GetIsTimeSet();
        if (!isTimeSet)
        {
            PersistentData.Instance.SetIsTimeSet(true);
            PersistentData.Instance.SetStartTime();
            isTimeSet = true;
        }
        startHour = PersistentData.Instance.GetStartHour();
        startMinute = PersistentData.Instance.GetStartMinute();
        startSecond = PersistentData.Instance.GetStartSecond();
        totalSeconds = startHour*SECINHR + startMinute*SECINMIN + startSecond;
    }

    // Update is called once per frame
    void Update()
    {
        DisplayTime();
    }

    void DisplayTime()
    {
        DateTime t = DateTime.Now;

        int totalInSecs = t.Hour*SECINHR + t.Minute*SECINMIN + t.Second - totalSeconds;

        int second = totalInSecs % SECINMIN;
        int minutesLeft = (totalInSecs - second) / SECINMIN;
        int minute = minutesLeft % MININHR;
        int hour = minutesLeft / MININHR;
        
        int taskToDo = PersistentData.Instance.GetTasksLeft();
        int taskComplete = PersistentData.Instance.GetNumTasks() - taskToDo;

        

        time.text = Format(hour) + ":" + Format(minute) + ":" + Format(second);
        tasks.text = "Tasks done " + + taskComplete;
    }

    private string Format(int x)
    {
        return x.ToString("00");
    }
}
