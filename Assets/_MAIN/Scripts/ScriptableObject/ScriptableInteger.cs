using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Scriptable Integer", menuName = "Scriptable Variable/Integer")]
public class ScriptableInteger : ScriptableObject
{
    public int sCounter, sTimer, value;

    private void OnEnable()
    {
        sCounter = value;
        sTimer = value;
    }

    public void ResetOnExitPlay()
    {
        sCounter = value;
        sTimer = value;
    }
}
