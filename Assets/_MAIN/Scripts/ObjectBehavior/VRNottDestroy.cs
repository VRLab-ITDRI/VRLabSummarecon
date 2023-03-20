using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRNottDestroy : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
