using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Services.Analytics;

public class youwin : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        SceneManager.LoadScene("Success");
        Unity.Services.Analytics.CustomEvent PlayerWin = new Unity.Services.Analytics.CustomEvent("PlayerWin");
        PlayerWin.Add("timeFromStartFloat", Time.timeSinceLevelLoad);
        AnalyticsService.Instance.RecordEvent(PlayerWin);
        
    }
}
