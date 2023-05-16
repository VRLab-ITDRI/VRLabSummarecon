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
        string uri = "https://sfcerenity.org/api/room";
        string uri2 = "https://sfcerenity.org/api/time";
        
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

        WWWForm form2 = new WWWForm();
        form2.AddField("Pintu", Pintu.sTimer);
        form2.AddField("RuangTamuDepan", RuangTamuDepan.sTimer);
        form2.AddField("RuangMakan", RuangMakan.sTimer);
        form2.AddField("HalamanDepan", HalamanDepan.sTimer);
        form2.AddField("Lantai2", Lantai2.sTimer);
        form2.AddField("Balkon", Balkon.sTimer);
        form2.AddField("Kamar", Kamar.sTimer);
        form2.AddField("Toilet", Toilet.sTimer);

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
