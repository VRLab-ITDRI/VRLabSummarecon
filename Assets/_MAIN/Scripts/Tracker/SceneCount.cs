using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneCount : MonoBehaviour
{
    public ScriptableInteger sceneCounts;

    private void Start()
    {
        sceneCounts.sCounter += 1;
    }
}
