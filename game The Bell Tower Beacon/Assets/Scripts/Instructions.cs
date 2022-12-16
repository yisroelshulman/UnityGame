using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Instructions : MonoBehaviour
{

    [SerializeField] TMP_Text instruc;

    const int NUMPAGES = 6;
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
        pages[0] = "Please note:\n\n" +
                    "The movement behavior is intentional; the player can only move horizontal or vertical and not diagonal.\n\n" +
                    "Tasks are a little monotonous - in the future we hope to include a better description and small motivation/backstory for each quest.";
        pages[1] = "Introduction:\n\n" +
                    "The goal of the game is to teach the player about various resources that are available to students at Brooklyn college. The player is introduced " +
                    "to a resource through a task/quest, the quest requires the player to go to a specific building and room on campus where the center for that " +
                    "resource is located.";
        pages[2] = "Through playing this game the player will learn about ten resources on campus and how to navigate the Brooklyn college campus. " +
                    "Additionally, the map contains the offices for various academic departments at Brooklyn College.\n\n" +
                    "The second portion of the game is an exam that tests the player on the information learnt in the tasks/quests section. There are ten questions, one " +
                    "related to each task done.\n";
        pages[3] = "As an incentive to get better the game keeps a high score for fastest completion time of the tasks and for the highest score on the exam. To balance " +
                    "the game from bad RNG in task order the player spawn at the same location after completing each task.\n\n" +
                    "There are three game modes offered full which has both the tasks and the exam at the end. Tasks, which only includes the task portion of the game, " +
                    "and Exam which only includes the exam.\n";
        pages[4] = "Although the task section is timed, we encourage the player to try a play through without completion to explore campus and learn how to navigate, there " +
                    "is a lot of information in the map.\n";
        pages[5] = "Thank you and we hope you enjoy our game!";
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
