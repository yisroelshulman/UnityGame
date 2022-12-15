using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Instructions : MonoBehaviour
{

    [SerializeField] TMP_Text instruc;

    const int NUMPAGES = 3;
    string[] pages = new string[NUMPAGES];
    int currentPage;

    // Start is called before the first frame update
    void Start()
    {
        InitInstruct();
        currentPage = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InitInstruct()
    {
        pages[0] = "Still working on:\nTimer - a timer to complete the tasks in the allotted time.\nZoom function - the ability to" + 
                    "zoom in and out on the main map to help with visibility.\nTo pause the game press the \"p\" key.\nSound controls," +
                    " (Tutorial and game are the same).\nTasks - a better description and small motivation/backstory for each task. A" +
                    " way to see which task is currently active.\nPenalties - need to add functionality to increase time played by" +
                    " penalty amount when the wrong room is entered (or when the wrong task is being selected to complete).\n\n" +
                    "Note:\nThe movement is intentional, the player can only move horizontal or vertical and not diagonal.";
        pages[1] = "Instructions:\nThe goal of the game is to teach the player about campus resources, as such the player will have" +
                    " tasks to complete which will highlight the resource and where/how to access it. The player will move around" +
                    " campus going to specific rooms in buildings (be careful the wrong room will waste some time). Tasks will be timed" +
                    " and a final exam at the end will evaluate how well the player knows resources around campus and where to find them.\n" +
                    "The player can move around the map using the arrow keys or the WASD keys. Next to every enterable building there is an" +
                    " outline zone, when the player is in that zone hitting enter on the keyboard will enter the building.\n";
        pages[2] = "To get a new task the player must go to the West Quad Building and select the get task Button. A new task will appear on the screen. When" +
                    " the task is complete the task done/complete count will increase. When all 10 tasks are complete the player will have the" +
                    "option to end the game or take the Final exam. (Be careful failure to complete a task will waste time since there is a time penalty).\n" +
                    "There are two high scores, one is the in-game time to complete all 10 tasks. The second is score on the Final Exam.";
        instruc.text = pages[currentPage];
    }

    public void NextPage()
    {
        if (currentPage < NUMPAGES-1)
        {
            currentPage++;
        }
        instruc.text = pages[currentPage];
    }

    public void PrevPage()
    {
        if (currentPage > 0)
        {
            currentPage--;
        }
        instruc.text = pages[currentPage];
    }

    public void RulesBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
