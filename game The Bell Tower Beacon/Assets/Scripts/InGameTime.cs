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
    int startSeconds;

    const int SECINMIN = 60;
    const int SECINHR = SECINMIN * 60;
    const int MININHR = 60;
    
    bool started;

    // Start is called before the first frame update
    void Start()
    {
        started = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!started)
        {
            started = PersistentData.Instance.GetIsTimeSet();
            startSeconds = PersistentData.Instance.GetTotalStartSeconds();
        }
        DisplayTime();
    }

    void DisplayTime()
    {

        int taskToDo = PersistentData.Instance.GetTasksLeft();
        int taskComplete = PersistentData.Instance.GetNumTasks() - taskToDo;

        if (!started)
        {
            time.text = Format(0) + ":" + Format(0) + ":" + Format(0);
            tasks.text = "Tasks done " + + taskComplete;
            return;
        }
        DateTime t = DateTime.Now;

        int penaltySeconds = PersistentData.Instance.GetPenaltyTime();
        int totalInSecs = t.Hour*SECINHR + t.Minute*SECINMIN + t.Second - startSeconds + penaltySeconds;

        int second = totalInSecs % SECINMIN;
        int minutesLeft = (totalInSecs - second) / SECINMIN;
        int minute = minutesLeft % MININHR;
        int hour = minutesLeft / MININHR;

        

        time.text = Format(hour) + ":" + Format(minute) + ":" + Format(second);
        tasks.text = "Tasks done " + + taskComplete;
    }

    private string Format(int x)
    {
        return x.ToString("00");
    }
}
