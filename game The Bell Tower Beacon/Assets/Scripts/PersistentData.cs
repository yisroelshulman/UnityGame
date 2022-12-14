using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PersistentData : MonoBehaviour
{

    [SerializeField] static float xOffset;
    [SerializeField] static float yOffset;
    [SerializeField] static bool isTimeSet;
    [SerializeField] static bool isTaskActive;
    static int startHour;
    static int startMinute;
    static int startSecond;

    const int SECINMIN = 60;
    const int SECINHR = SECINMIN * 60;
    const int NUMTASKS = 10;

    static Dictionary<int, string> tasks;
    static int[] tasksLeftList = new int[NUMTASKS];

    static int taskLeft;
    static int currentTask;
    static int index;

    public static PersistentData Instance;

    private int examCorrect;
    private int examWrong;

    public void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
            xOffset = 0;
            yOffset = 0;
            isTimeSet = false;
            isTaskActive = false;
            SetTasks();
            taskLeft = NUMTASKS;
        }
        else
            Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float GetXOffset()
    {
        return xOffset;
    }

    public float GetYOffset()
    {
        return yOffset;
    }

    public bool GetIsTimeSet()
    {
        return isTimeSet;
    }

    public bool GetIsTaskActive()
    {
        return isTaskActive;
    }

    public int GetStartHour()
    {
        return startHour;
    }

    public int GetStartMinute()
    {
        return startMinute;
    }

    public int GetStartSecond()
    {
        return startSecond;
    }

    public int GetTasksLeft()
    {
        return taskLeft;
    }

    public int GetNumTasks()
    {
        return NUMTASKS;
    }

    public int GetExamCorrect()
    {
        return examCorrect;
    }

    public int GetExamWrong()
    {
        return examWrong;
    }

    public string GetTask()
    {
        if (isTaskActive)
        {
            return tasks[currentTask];
        }
        index = UnityEngine.Random.Range(0, taskLeft);
        currentTask = tasksLeftList[index];
        isTaskActive = true;
        return tasks[currentTask];
    }

    public string GetCurrentTask()
    {
        return tasks[currentTask];
    }

    public void CompleteTask(int task)
    {
        if (task == currentTask)
        {
            isTaskActive = false;
            tasksLeftList[index] = tasksLeftList[taskLeft - 1];
            taskLeft--;
            currentTask = -1;
        }
    }




    public void SetXOffset(float x)
    {
        xOffset = x;
    }

    public void SetYOffset(float y)
    {
        yOffset = y;
    }

    public void SetIsTimeSet(bool set)
    {
        isTimeSet = set;
    }

    public void SetIsTaskActive(bool active)
    {
        isTaskActive = active;
    }

    public void SetStartTime()
    {
        DateTime time = DateTime.Now;
        startHour = time.Hour;
        startMinute = time.Minute;
        startSecond = time.Second;
    }

    private void SetTasks()
    {
        tasks = new Dictionary<int, string>()
        {
            {0, "Find the Learning Center, Room 1300 in Boylan Hall."},
            {1, "Find the Women's Center, Room 227 in Ingersoll Extension."},
            {2, "Find the Magner Center, Room 1303 in James Hall."},
            {3, "Find the Personal Counseling Center, Room 0203 in James Hall."},
            {4, "Find the Health Clinic, Room 114 in Roosevelt Hall."},
            {5, "Find the Food Pantry, Room 312 in SUBO (Student Center)."},
            {6, "Find tech Support in the WEB Building, in the WEB Building."},
            {7, "Get Tech Support in the Library, in the Library."},
            {8, "Get Information from the Registrar, Room  306 in the West Quad Building."},
            {9, "Get Information for the Financial Aid Office, Room 308 in the West Quad Building."}
        };
        for (int i = 0; i < NUMTASKS; i++)
        {
            tasksLeftList[i] = i;
        }
    }

    public void SetExamCorrect(int correct)
    {
        examCorrect = correct;
    }

    public void SetExamWrong(int wrong)
    {
        examWrong = wrong;
    }

}

