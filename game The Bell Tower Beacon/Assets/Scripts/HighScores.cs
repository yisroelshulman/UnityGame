using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScores : MonoBehaviour
{
    const int NUM_HIGH_SCORES = 5;
    const string NAME_KEY = "Player";
    const string SCORE_KEY = "Score";

    private string playerName;
    private int playerExamScore;
    private int playerTime;
 
    [SerializeField] TMP_Text[] nameTextsTime;
    [SerializeField] TMP_Text[] scoreTextsTime;

    [SerializeField] TMP_Text[] nameTextsExam;
    [SerializeField] TMP_Text[] scoreTextsExam;

    [SerializeField] TMP_Text playerInfo;

    const int SECINMIN = 60;
    const int SECINHR = SECINMIN * 60;
    const int MININHR = 60;


    // Start is called before the first frame update
    void Start()
    {
        playerName = PersistentData.Instance.GetName();
        playerExamScore = Mathf.RoundToInt(PersistentData.Instance.GetExamScore());
        playerTime = PersistentData.Instance.GetTime();
        if (playerExamScore > 0)
        {
            SaveTimeHighScores();
            SaveExamHighScores();
        }
        ShowHighScores();
    }

    public void SaveTimeHighScores()
    {
        if (playerTime < 0)
        {
            return;
        }
        for (int i = 1; i <= NUM_HIGH_SCORES; i++)
        {
            string currentNameKey = NAME_KEY + i;
            string currentTimeKey = SCORE_KEY + i;

            if (PlayerPrefs.HasKey(currentTimeKey))
            {
                int currentTime = PlayerPrefs.GetInt(currentTimeKey);
                if (playerTime < currentTime)
                {
                    int tempTime = currentTime;
                    string tempName = PlayerPrefs.GetString(currentNameKey);

                    PlayerPrefs.SetString(currentNameKey, playerName);
                    PlayerPrefs.SetInt(currentTimeKey, playerTime);

                    playerName = tempName;
                    playerTime = tempTime;

                }
            }
            else
            {
                PlayerPrefs.SetString(currentNameKey, playerName);
                PlayerPrefs.SetInt(currentTimeKey, playerTime);
                return;
            }
        }
    }

    public void SaveExamHighScores()
    {
        if (playerExamScore <= 0)
        {
            return;
        }
        for (int i = NUM_HIGH_SCORES + 1; i <= NUM_HIGH_SCORES*2; i++)
        {
            string currentNameKey = NAME_KEY + i;
            string currentScoreKey = SCORE_KEY + i;

            if (PlayerPrefs.HasKey(currentScoreKey))
            {
                int currentScore = PlayerPrefs.GetInt(currentScoreKey);
                if (playerExamScore > currentScore)
                {
                    int tempScore = currentScore;
                    string tempName = PlayerPrefs.GetString(currentNameKey);

                    PlayerPrefs.SetString(currentNameKey, playerName);
                    PlayerPrefs.SetInt(currentScoreKey, playerExamScore);

                    playerName = tempName;
                    playerExamScore = tempScore;
                }
            }
            else
            {
                PlayerPrefs.SetString(currentNameKey, playerName);
                PlayerPrefs.SetInt(currentScoreKey, playerExamScore);
                return;
            }
        }
    }

    public void ShowHighScores()
    {
        for (int i = 0; i < NUM_HIGH_SCORES; i++)
        {
            nameTextsTime[i].text = PlayerPrefs.GetString(NAME_KEY + (i + 1), "Player " + (i + 1));
            string s = ConvertTime(PlayerPrefs.GetInt(SCORE_KEY + (i + 1)));
            scoreTextsTime[i].text = s;
        }

        for (int i = 0; i < NUM_HIGH_SCORES; i++)
        {
            nameTextsExam[i].text = PlayerPrefs.GetString(NAME_KEY + (i + NUM_HIGH_SCORES + 1), "Player " + (i + 1));
            scoreTextsExam[i].text = PlayerPrefs.GetInt(SCORE_KEY + (i + NUM_HIGH_SCORES + 1)).ToString();
        }

        string time = playerTime.ToString();
        if (playerTime < 0)
        {
            time = "N/A";
        }
        string score = playerExamScore.ToString();
        playerInfo.text = playerName + ": Time " + time + ", Exam Score " + score;
    }

    private string ConvertTime(int seconds)
    {
        int second = seconds % SECINMIN;
        int minutesLeft = (seconds - second) / SECINMIN;
        int minute = minutesLeft % MININHR;
        int hour = minutesLeft / MININHR;
        return Format(hour) + ":" + Format(minute) + ":" + Format(second);
    }

    private string Format(int x)
    {
        return x.ToString("00");
    }

}