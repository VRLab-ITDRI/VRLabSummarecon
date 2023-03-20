using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRChangeFurnitureColor : MonoBehaviour
{
    public Renderer rend;
    public Material[] mat;
    public int debugChangeColorTo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_EDITOR
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rend.sharedMaterial = mat[debugChangeColorTo];
        }
#endif
    }

    public void ChangeColorTo(int x)
    {
        rend.sharedMaterial = mat[x];
    }
}
