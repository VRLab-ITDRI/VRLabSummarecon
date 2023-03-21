using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRNotDestroy : MonoBehaviour
{
    private static VRNotDestroy instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            return;
        }
        Destroy(this.gameObject);
    }
}
