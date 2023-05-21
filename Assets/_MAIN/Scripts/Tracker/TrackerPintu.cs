using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackerPintu : MonoBehaviour
{
    public int counterPintu;
    public float timerPintu;

    // Start is called before the first frame update
    void Start()
    {
        counterPintu += 1;
    }

    // Update is called once per frame
    void Update()
    {
        timerPintu = timerPintu + Time.deltaTime;

    }
}
