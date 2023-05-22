using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class VRLabSceneCounter : MonoBehaviour
{
    #region _VARIABLE
    public string sceneCounterName, sceneTimerName;

    private float currentTime;
    #endregion

   #region _UNITY FUNCTION
    private void Start()
    {
        PlayerPrefs.SetInt(sceneCounterName, PlayerPrefs.GetInt(sceneCounterName) + 1);
    }

    private void Update()
    {
#if UNITY_EDITOR
        //Debug.Log("Count: " + PlayerPrefs.GetInt(sceneCounterName) + "Timer: " + PlayerPrefs.GetInt(sceneTimerName));
#endif
        currentTime = currentTime + Time.deltaTime;
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        PlayerPrefs.SetInt(sceneTimerName, PlayerPrefs.GetInt(sceneTimerName) + (int)currentTime);
    }
    #endregion

    #region _COROUTINE
    IEnumerator ChangeTime()
    {

        yield return new WaitForSeconds(0.1f);
        
    }
    #endregion
}
