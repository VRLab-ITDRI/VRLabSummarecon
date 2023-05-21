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
        PlayerPrefs.SetInt(sceneCounterName, + 1);
    }

    private void Update()
    {
        currentTime = currentTime + Time.deltaTime;
        PlayerPrefs.SetInt(sceneTimerName, + (int)currentTime);
    }
    #endregion
}
