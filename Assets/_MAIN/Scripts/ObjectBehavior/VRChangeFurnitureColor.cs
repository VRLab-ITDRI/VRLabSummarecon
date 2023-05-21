using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRChangeFurnitureColor : MonoBehaviour
{
    public Renderer rend;
    public Material[] mat;
    public GameObject[] colorButton;
    private int choosedColor = 0;
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
            rend.sharedMaterial = mat[choosedColor];
        }
#endif
        if(choosedColor == 0)
        {
            StartCoroutine(DisableButton());
            colorButton[1].SetActive(true);
            rend.sharedMaterial = mat[choosedColor];
        }
        if (choosedColor == 1)
        {
            StartCoroutine(DisableButton());
            colorButton[2].SetActive(true);
            rend.sharedMaterial = mat[choosedColor];
        }
        if (choosedColor == 2)
        {
            StartCoroutine(DisableButton());
            colorButton[3].SetActive(true);
            rend.sharedMaterial = mat[choosedColor];
        }
        if (choosedColor == 3)
        {
            StartCoroutine(DisableButton());
            colorButton[4].SetActive(true);
            rend.sharedMaterial = mat[choosedColor];
        }
        if (choosedColor == 4)
        {
            StartCoroutine(DisableButton());
            colorButton[0].SetActive(true);
            rend.sharedMaterial = mat[choosedColor];
        }

#if UNITY_EDITOR
        //Debug.Log("Warna sekarang: " + choosedColor);
#endif
    }

    public void ChangeColorTo(int x)
    {
        choosedColor = x;
    }

    private IEnumerator DisableButton()
    {
        // tambah array game object button disini
        //colorButton[0].SetActive(false);
        //colorButton[1].SetActive(false);
        //colorButton[2].SetActive(false);
        //colorButton[3].SetActive(false);
        //colorButton[4].SetActive(false);
        yield return new WaitForSeconds(0.5f);
    }
}
