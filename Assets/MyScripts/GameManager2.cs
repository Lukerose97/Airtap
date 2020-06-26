using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    //Variable to keep track of current score
    int currentScore;

    //Variable to add to current score
    public int scorePerNote = 100;

    //Continuing squence of notes hit
    int streak = 0;

    //Variable for the multiplier
    int multiplier = 1;

    private void Start()
    {
        PlayerPrefs.SetInt("Score", 0);
        PlayerPrefs.SetInt("Streak", 0);
        PlayerPrefs.SetInt("Mult", 1);
        PlayerPrefs.SetInt("HitMeter", 25);
        PlayerPrefs.SetInt("HighStreak", 0);
        PlayerPrefs.SetInt("NotesHit", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addStreak()
    {
        if(PlayerPrefs.GetInt("HitMeter") + 1 < 50)
        {
            PlayerPrefs.SetInt("HitMeter", PlayerPrefs.GetInt("HitMeter") + 1);
        }
        streak++;
        if(streak >= 24)
        {
            multiplier = 4;
        }else if(streak >= 16)
        {
            multiplier = 3;
        }else if(streak >= 8)
        {
            multiplier = 2;
        }
        else
        {
            multiplier = 1;
        }
        if(streak > PlayerPrefs.GetInt("HighStreak"))
        {
            PlayerPrefs.SetInt("HighStreak", streak);
        }

        PlayerPrefs.SetInt("NotesHit", PlayerPrefs.GetInt("NotesHit") + 1);

        UpdateGUI();
    }

    public void ResetStreak()
    {
        PlayerPrefs.SetInt("HitMeter", PlayerPrefs.GetInt("HitMeter") -2);
        if (PlayerPrefs.GetInt("HitMeter") < 0)
        {
            Lose();
        }
        
        streak = 0;
        multiplier = 1;
        UpdateGUI();
    }

    public void Lose()
    {
        //Debug.Log("You Lose");
        SceneManager.LoadScene(3);
    }

    public void Win()
    {
        //Debug.Log("You Win");
        if (PlayerPrefs.GetInt("HighScore") < PlayerPrefs.GetInt("Score"))
        {
            PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("Score"));
        }
        SceneManager.LoadScene(4);
    }

    private void OnTriggerEnter(Collider killZone)
    {
        Destroy(killZone.gameObject);
        ResetStreak();
    }

    void UpdateGUI()
    {
        PlayerPrefs.SetInt("Streak", streak);
        PlayerPrefs.SetInt("Mult", multiplier);
    }

    public int getScore()
    {
        return 100 * multiplier;
    }
}
