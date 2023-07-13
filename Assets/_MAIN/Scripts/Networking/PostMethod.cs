using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PostMethod : MonoBehaviour
{
    #region _VARIABLE
    [Header("Debug Counter API")]
    public int debugCounterPintu;
    public int debugCounterRuangTamu;
    public int debugCounterRuangMakan;
    public int debugCounterHalamanDepan;
    public int debugCounterLantai2;
    public int debugCounterBalkon;
    public int debugCounterKamar;
    public int debugCounterToilet;

    [Header("Debug Timer API")]
    public int debugTimerPintu;
    public int debugTimerRuangTamu;
    public int debugTimerRuangMakan;
    public int debugTimerHalamanDepan;
    public int debugTimerLantai2;
    public int debugTimerBalkon;
    public int debugTimerKamar;
    public int debugTimerToilet;
    #endregion

    private void Start()
    {

    }

    private void Update()
    {
        debugCounterPintu = PlayerPrefs.GetInt("CounterPintu");
        debugCounterRuangTamu = PlayerPrefs.GetInt("CounterRuangTamu");
        debugCounterRuangMakan = PlayerPrefs.GetInt("CounterRuangMakan");
        debugCounterHalamanDepan = PlayerPrefs.GetInt("CounterHalamanDepan");
        debugCounterLantai2 = PlayerPrefs.GetInt("CounterLantai2");
        debugCounterBalkon = PlayerPrefs.GetInt("CounterBalkon");
        debugCounterKamar = PlayerPrefs.GetInt("CounterKamar");
        debugCounterToilet = PlayerPrefs.GetInt("CounterToilet");

        debugTimerPintu = PlayerPrefs.GetInt("TimerPintu");
        debugTimerRuangTamu = PlayerPrefs.GetInt("TimerRuangTamu");
        debugTimerRuangMakan = PlayerPrefs.GetInt("TimerRuangMakan");
        debugTimerHalamanDepan = PlayerPrefs.GetInt("TimerHalamanDepan");
        debugTimerLantai2 = PlayerPrefs.GetInt("TimerLantai2");
        debugTimerBalkon = PlayerPrefs.GetInt("TimerBalkon");
        debugTimerKamar = PlayerPrefs.GetInt("TimerKamar");
        debugTimerToilet = PlayerPrefs.GetInt("TimerToilet");
    }

    #region _PUBLIC FUNCTION
    public void PostData()
    {
        StartCoroutine(PostData_Coroutine());
    }

    [ContextMenu("Reset PlayerPrefs Data")]
    public void ResetPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
    #endregion

    #region _COROUTINE
    IEnumerator PostData_Coroutine()
    {
        string uri = "https://summarecon.virtualreality-lab.com/api/room";
        string uri2 = "https://summarecon.virtualreality-lab.com/api/time";
        
        WWWForm form = new WWWForm();
        form.AddField("Pintu",debugCounterPintu);
        form.AddField("RuangTamuDepan", debugCounterRuangTamu);
        form.AddField("RuangMakan", debugCounterRuangMakan);
        form.AddField("HalamanDepan", debugCounterHalamanDepan);
        form.AddField("Lantai2", debugCounterLantai2);
        form.AddField("Balkon", debugCounterBalkon);
        form.AddField("Kamar", debugCounterKamar);
        form.AddField("Toilet", debugCounterToilet);

        using (UnityWebRequest request = UnityWebRequest.Post(uri, form))
        {
            if (request.isHttpError || request.isNetworkError)
            {
                yield return request.error;
            }
            yield return request.SendWebRequest();

        }

        WWWForm form2 = new WWWForm();
        form2.AddField("Pintu", debugTimerPintu);
        form2.AddField("RuangTamuDepan", debugTimerRuangTamu);
        form2.AddField("RuangMakan", debugTimerRuangMakan);
        form2.AddField("HalamanDepan", debugTimerHalamanDepan);
        form2.AddField("Lantai2", debugTimerLantai2);
        form2.AddField("Balkon", debugTimerBalkon);
        form2.AddField("Kamar", debugTimerKamar);
        form2.AddField("Toilet", debugTimerToilet);

        using (UnityWebRequest request = UnityWebRequest.Post(uri2, form2))
        {
            if (request.isHttpError || request.isNetworkError)
            {
                yield return request.error;
            }
            yield return request.SendWebRequest();
        }
    }
    #endregion
}
