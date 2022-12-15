using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalExamScript : MonoBehaviour
{

    [SerializeField] TMP_Text questions;
    [SerializeField] TMP_Text button;

    [SerializeField] Toggle t1;
    [SerializeField] Toggle t2;
    [SerializeField] Toggle t3;
    [SerializeField] Toggle t4;

    private const int NUMQS = 10;
    private const int NUMTOGS = 4;
    private string[] exam =  new string[NUMQS + 1];
    private string[] choices = new string[NUMQS * NUMTOGS];
    private int[] answerKey = new int[NUMQS];

    private int numCorrect;
    private int numWrong;
    private int selection;

    // the question we are up to
    int current;


    // Start is called before the first frame update
    void Start()
    {
        current = 0;
        InitQuestions();
        InitChoice();
        InitAnswerKey();
        numCorrect = 0;
        numWrong = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitQuestions()
    {
        exam[0] = "Instructions:\n\nPlease read the questions carfully and select your answer. Click the Next button to save your answer and go to the next question.\nThere is no backtracking!";
        exam[1] = "Question 1\n\nOne of the locations to go for help when you have trouble logging into the BC WiFi is?";
        exam[2] = "Question 2\n\nThe office of Personal Counciling can be found in which building?";
        exam[3] = "Question 3\n\nYou're having trouble with registered for classes the registrar's office can be found at?";
        exam[4] = "Question 4\n\nFor help with a class or writing you can go to the Learning Center, which is located at";
        exam[5] = "Question 5\n\nThe Food Pantry which helps studetns with basic Foods is located in";
        exam[6] = "Question 6\n\nFor help with your college emails or CUNY First account you can consult";
        exam[7] = "Question 7\n\nYou want to create/touch up your resume you go visit the Magenr Center at";
        exam[8] = "Question 8\n\nAs a BC student you have access to the Health Clinic in";
        exam[9] = "Question 9\n\nThe Financial Aid Office is located at";
        exam[10] = "Question 10\n\nThe Women's Center is in which building?";

        questions.text = exam[current];
    }

    void InitChoice()
    {
        choices[0] = "Computer Science Department, Room 2109 Ingersoll Hall.";
        choices[1] = "WEB Building.";
        choices[2] = "Information Desk, West Quad Building.";
        choices[3] = "Student Affairs, 2nd Floor Boylan Hall.";
        choices[4] = "Whitehead Hall";
        choices[5] = "Roosevelt Hall";
        choices[6] = "James Hall";
        choices[7] = "Ingersoll Hall";
        choices[8] = "Room 1416 Boylan Hall";
        choices[9] = "Room 306 West Quad Building";
        choices[10] = "Room 2113 Boylan Hall";
        choices[11] = "Room 311 SUBO";
        choices[12] = "Room 1300, Boylan Hall";
        choices[13] = "Room 1300, James Hall";
        choices[14] = "Room 1300, Roosevelt Hall";
        choices[15] = "Room 1300 Ingersoll Hall";
        choices[16] = "The West Quad Building";
        choices[17] = "Library Cafe";
        choices[18] = "Boyalan Hall Cafeteria";
        choices[19] = "SUBO";
        choices[20] = "The Library Second Floor Information Desk";
        choices[21] = "Campus Safety";
        choices[22] = "Information Desk, West Quad Building";
        choices[23] = "Informatio Desk, The Learning Center";
        choices[24] = "253A Whitehead Hall";
        choices[25] = "429 Ingersoll Extension";
        choices[26] = "1303 James Hall";
        choices[27] = "2154 Boylan Hall";
        choices[28] = "Ingersoll Hall";
        choices[29] = "Ingersoll Extension";
        choices[30] = "SUBO";
        choices[31] = "Roosevelt Hall";
        choices[32] = "308 West Quad Building";
        choices[33] = "2119 Boylan Hall";
        choices[34] = "WEB Building";
        choices[35] = "205 Whitehead Hall";
        choices[36] = "Roosevelt Hall";
        choices[37] = "Ingersoll Extentsion";
        choices[38] = "James Hall";
        choices[39] = "SUBO";
    }

    void InitAnswerKey()
    {
        answerKey[0] = 1;
        answerKey[1] = 2;
        answerKey[2] = 1;
        answerKey[3] = 0;
        answerKey[4] = 3;
        answerKey[5] = 0;
        answerKey[6] = 2;
        answerKey[7] = 3;
        answerKey[8] = 0;
        answerKey[9] = 1;
    }

    public void Next()
    {
        if (current > 0)
        {
            if (t1.isOn)
            {
                selection = 0;
            }
            if (t2.isOn)
            {
                selection = 1;
            }
            if (t3.isOn)
            {
                selection = 2;
            }
            if (t4.isOn)
            {
                selection = 3;
            }

            if (answerKey[current - 1] == selection)
            {
                numCorrect++;
            }
            else
            {
                numWrong++;
            }
        }

        

        // done
        if (current >= NUMQS)
        {
            PersistentData.Instance.SetExamCorrect(numCorrect);
            PersistentData.Instance.SetExamWrong(numWrong);
            SceneManager.LoadScene("HighScores");
            return;
        }        

        t1.GetComponentInChildren<Text> ().text = choices[current*NUMTOGS + 0];
        t2.GetComponentInChildren<Text> ().text = choices[current*NUMTOGS + 1];
        t3.GetComponentInChildren<Text> ().text = choices[current*NUMTOGS + 2];
        t4.GetComponentInChildren<Text> ().text = choices[current*NUMTOGS + 3];

        current++;
        questions.text = exam[current];

        if (current == NUMQS)
        {
            button.text = "Submit";
        }
    }
}
