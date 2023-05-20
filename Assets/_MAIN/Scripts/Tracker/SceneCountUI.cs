using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneCountUI : MonoBehaviour
{
    public Text text;
    public ScriptableInteger sceneCounts;

    void Update()
    {
        text.text = sceneCounts.sCounter.ToString();
    }
}
