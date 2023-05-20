using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;


public class SceneTimerCount : MonoBehaviour
{
    #region _VARIABLE
    private bool stopwatchActive = true;
    private float currentTime;

    //public Text timerText;
    public ScriptableInteger timerCounts;
    #endregion

    #region _UNITY FUNCTION
    private void Start()
    {
        //currentTime = 0;
    }

    void Update()
    {
        if (stopwatchActive == true)
        {
            currentTime = currentTime + Time.deltaTime;
        }
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        //timerText.text = time.Hours.ToString() + ":" + time.Minutes.ToString() + ":" + time.Seconds.ToString();

        //timerCounts.value += Convert.ToInt32(currentTime);
        timerCounts.sTimer += (int)currentTime;
    }
    #endregion

    #region _PUBLIC FUNCTION
    public void StartTimer()
    {
        stopwatchActive = true;
    }

    public void StopTimer()
    {
        stopwatchActive = false;
    }
    #endregion

    #region _PRIVATE FUNCTION
    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        else if (timeToDisplay == 0)
        {
            //MenuUI.instance.TimeOver();
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        //timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    #endregion
}
