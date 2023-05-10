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

    void Start()
    {
        
    }

    public void PostData()
    {
        StartCoroutine(PostData_Coroutine());
    }

    IEnumerator PostData_Coroutine()
    {
        string uri = "https://my-json-server.typicode.com/typicode/demo/posts";

        WWWForm form = new WWWForm();
        form.AddField("Pintu", $"muran");

        using (UnityWebRequest request = UnityWebRequest.Post(uri, form))
        {
            yield return request.SendWebRequest();

        }
    }
}
