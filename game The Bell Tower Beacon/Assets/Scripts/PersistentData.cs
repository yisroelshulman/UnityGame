using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class PersistentData : MonoBehaviour
{

    [SerializeField] static float xOffset;
    [SerializeField] static float yOffset;
    [SerializeField] static bool isTimeSet;
    [SerializeField] static bool isTaskActive;
    [SerializeField] string playerName;
    [SerializeField] float playerExamScore;
    [SerializeField] int playerTime;

    private const string CAMPUS = "Campusv2BetterMovementLogic";


    static int startTotalSeconds;

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

    const int FULL = 0;
    const int TASK = 1;
    const int EXAM = 2;

    static int mode;

    private int penaltyCount;
    const int PENALTYTIME = 2; // in seconds

    bool isTutorial;

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
            playerName = "";
            playerExamScore = 0;
            playerTime = -1;
            mode = FULL;
            penaltyCount = 0;
            isTutorial = false;
            ResetPlayerExamScore();
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

    public int GetTotalStartSeconds()
    {
        return startTotalSeconds;
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

    public string GetName()
    {
        return playerName;
    }

    public float GetExamScore()
    {
        if (examCorrect + examWrong == 0)
        {
            return 0f;
        }
        playerExamScore = (float) examCorrect / (examCorrect + examWrong);
        return playerExamScore*100;
    }

    public int GetTime()
    {
        return playerTime + GetPenaltyTime() - startTotalSeconds;
    }

    public int GetMode()
    {
        return mode;
    }

    public int GetPenaltyTime()
    {
        return penaltyCount * PENALTYTIME;
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
        if (isTaskActive && !isTutorial)
        {
            return tasks[currentTask];
        }
        return "Sample quest!";
    }

    public void CompleteTask(int task)
    {
        if (task == currentTask)
        {
            isTaskActive = false;
            tasksLeftList[index] = tasksLeftList[taskLeft - 1];
            taskLeft--;
            currentTask = -1;

            if (taskLeft == 0)
            {
                DateTime time = DateTime.Now;
                int hour = time.Hour;
                int minute = time.Minute;
                int second = time.Second;
                playerTime = hour*SECINHR + minute*SECINMIN + second;
                if (mode == TASK)
                {
                    SceneManager.LoadScene("HighScores");
                    return;
                }
                SceneManager.LoadScene("FinalExam");
                return;
            }
            xOffset = 0;
            yOffset = 0;
            SceneManager.LoadScene(CAMPUS);
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
        int hour = time.Hour;
        int minute = time.Minute;
        int second = time.Second;
        startTotalSeconds = hour*SECINHR + minute*SECINMIN + second;
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
            {6, "Find tech Support in the WEB Building."},
            {7, "Get Tech Support in the Library."},
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

    public void SetPlayerName(string s)
    {
        playerName = s;
    }

    public void SetMode(int md)
    {
        mode = md;
    }

    public void SetTutorial(bool active)
    {
        isTutorial = active;
    }

    public void ResetPlayerExamScore()
    {
        examCorrect = 0;
        examWrong = 0;
    }

    public void ResetPlayerTime()
    {
        playerTime = -1;
    }

    public void ResetTime()
    {
        startTotalSeconds = 0;
        isTimeSet = false;
    }

    public void ResetName()
    {
        playerName = "";
    }

    public void Reset()
    {
        ResetPlayerExamScore();
        ResetPlayerTime();
        ResetTime();
        ResetName();
        xOffset = 0;
        yOffset = 0;
        mode = FULL;
        isTaskActive = false;
        SetTasks();
        taskLeft = NUMTASKS;
        playerExamScore = 0;
        penaltyCount = 0;
        isTutorial = false;
    }

    public void IncreasePenaltyCount()
    {
        penaltyCount++;
    }

}