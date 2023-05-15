using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneCount : MonoBehaviour
{
    public ScriptableInteger sceneCounts;

    public void OnGain()
    {
        sceneCounts.sCounter += 1;
    }
}
