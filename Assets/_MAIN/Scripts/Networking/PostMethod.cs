using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PostMethod : MonoBehaviour
{
    public ScriptableInteger Pintu;
    public ScriptableInteger RuangTamuDepan;
    public ScriptableInteger RuangMakan;
    public ScriptableInteger HalamanDepan;
    public ScriptableInteger Lantai2;
    public ScriptableInteger Balkon;
    public ScriptableInteger Kamar;
    public ScriptableInteger Toilet;

    public void PostData()
    {
        StartCoroutine(PostData_Coroutine());
    }

    IEnumerator PostData_Coroutine()
    {
        string uri = "http://localhost:3000/tes";
        
        WWWForm form = new WWWForm();
        form.AddField("Pintu", Pintu.value);
        form.AddField("RuangTamuDepan", RuangTamuDepan.value);
        form.AddField("RuangMakan", RuangMakan.value);
        form.AddField("HalamanDepan", HalamanDepan.value);
        form.AddField("Lantai2", Lantai2.value);
        form.AddField("Balkon", Balkon.value);
        form.AddField("Kamar", Kamar.value);
        form.AddField("Toilet", Toilet.value);

        using (UnityWebRequest request = UnityWebRequest.Post(uri, form))
        {
            if (request.isHttpError || request.isNetworkError)
            {
                yield return request.error;
            }
            yield return request.SendWebRequest();

        }
    }
}
