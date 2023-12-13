using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Services.Analytics;

public class youwin : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        SceneManager.LoadScene("Success");
        AnalyticsService.Instance.CustomData("PlayerWin", new Dictionary<string, object>
        {
            {"timeFromStartFloat", Time.timeSinceLevelLoad}
        });
    }
}
