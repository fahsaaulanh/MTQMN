using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesQuran : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string apiUrl = "http://api.alquran.cloud/v1/ayah/262";
        APIManager.Instance.Get(apiUrl, onSuccess: (response) => { Debug.Log("Data" + response); }, onError: (error) => { Debug.Log("Data" + error); });
    }
}
