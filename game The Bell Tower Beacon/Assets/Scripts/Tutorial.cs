using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tutorial : MonoBehaviour
{

    const int NUMINSTRUCTS = 9;
    string[] instruct = new string[NUMINSTRUCTS];
    int current;

    [SerializeField] TMP_Text prompt;
    [SerializeField] TMP_Text button;

    [SerializeField] GameObject mapArrow;
    [SerializeField] GameObject infoArrow;
    [SerializeField] GameObject displayArrow;

    const int MAP = 3;
    const int INFO = 4;
    const int DISPLAY = 5;

    // Start is called before the first frame update
    void Start()
    {
        PersistentData.Instance.SetIsTaskActive(true);
        current = 0;
        PersistentData.Instance.SetTutorial(true);
        InitInstructs();
        ShowInstruct();
        Time.timeScale = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitInstructs()
    {
        instruct[0] = "Use the arrow keys or the \"W,\" \"A,\" \"S,\" \"D,\" keys to walk around campus";
        instruct[1] = "Press enter to go into a building, this can be done only in the entrance zones of the building represented by a shaded box.\n\n" +
                        "Note: some buildings have exits that can not be used as entrances.";
        instruct[2] = "To get a new Task the player must go in to the West Quad building and request a task/quest. Quests will require the player to go to the correct" +
                        " building and room number to complete, be careful entering the wrong room has a time penalty.";
        instruct[3] = "If the player is not sure where a building is, they can pull up the mini map which will show all the buildings and their relative location.\n\n" +
                        "(arrow points to the minimap icon press to view the map)";
        instruct[4] = "To view the current task, if one has been requested and not completed, please click the information icon.\n\nNote the icon will only be available when there is an active task.";
        instruct[5] = "The quest/task section of the game is timed, their is a timer and a quests complete counter on the display in the top right hand side of the screen.";
        instruct[6] = "To pause the game hit the \"P\" key on the keyboard.\n\nPlease note the timer does not pause when the game is paused.";
        instruct[7] = "The volume can be adjusted from the pause menu.";
        instruct[8] = "Thank you and Enjoy the game!";
    }

    void ShowInstruct()
    {
        mapArrow.SetActive(false);
        infoArrow.SetActive(false);
        displayArrow.SetActive(false);
        if (current == MAP)
        {
            mapArrow.SetActive(true);
        }
        if (current == INFO)
        {
            infoArrow.SetActive(true);
        }
        if (current == DISPLAY)
        {
            displayArrow.SetActive(true);
        }
        prompt.text = instruct[current];
    }


    public void NextInstruct()
    {
        current++;
        if (current >= NUMINSTRUCTS - 1)
        {
            button.text = "End";
        }
        if (current == NUMINSTRUCTS)
        {
            current--;
        }
        ShowInstruct();
    }

    public void PrevInstruct()
    {
        if (current > 0)
        {
            current--;
        }
        if (current < NUMINSTRUCTS - 1)
        {
            button.text = "Skip Tutorial";
        }
        ShowInstruct();
    }

    public void skip()
    {
        Time.timeScale = 1.0f;
        PersistentData.Instance.SetIsTaskActive(false);
        PersistentData.Instance.SetTutorial(false);
        PersistentData.Instance.SetIsTimeSet(true);
        PersistentData.Instance.SetStartTime();
        Destroy(gameObject);
    }
}
