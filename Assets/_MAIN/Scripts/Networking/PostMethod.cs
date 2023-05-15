using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PostMethod : MonoBehaviour
{
    #region _VARIABLE
    public ScriptableInteger Pintu;
    public ScriptableInteger RuangTamuDepan;
    public ScriptableInteger RuangMakan;
    public ScriptableInteger HalamanDepan;
    public ScriptableInteger Lantai2;
    public ScriptableInteger Balkon;
    public ScriptableInteger Kamar;
    public ScriptableInteger Toilet;
    #endregion

    #region _PUBLIC FUNCTION
    public void PostData()
    {
        StartCoroutine(PostData_Coroutine());
    }

    IEnumerator PostData_Coroutine()
    {
        string uri = "http://localhost:3000/tes";
        
        WWWForm form = new WWWForm();
        form.AddField("Pintu", Pintu.sCounter);
        form.AddField("RuangTamuDepan", RuangTamuDepan.sCounter);
        form.AddField("RuangMakan", RuangMakan.sCounter);
        form.AddField("HalamanDepan", HalamanDepan.sCounter);
        form.AddField("Lantai2", Lantai2.sCounter);
        form.AddField("Balkon", Balkon.sCounter);
        form.AddField("Kamar", Kamar.sCounter);
        form.AddField("Toilet", Toilet.sCounter);

        using (UnityWebRequest request = UnityWebRequest.Post(uri, form))
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
