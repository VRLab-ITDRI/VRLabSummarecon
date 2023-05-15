using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Scriptable Integer", menuName = "Scriptable Variable/Integer")]
public class ScriptableInteger : ScriptableObject
{
    public int sCounter, sTimer;
    public bool resetOnEnable;

    public void OnEnable()
    {
        if (resetOnEnable)
        {
            ResetValue();
        }
    }

    public void ResetValue()
    {
        sCounter = 0;
        sTimer = 0;
    }
}
