using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Services.Analytics;

public class youdied : MonoBehaviour
{
    public string deathReason = "undefinied";

    void OnTriggerEnter(Collider other){
        SceneManager.LoadScene("Death");
        Debug.Log("Player died");
        AnalyticsService.Instance.CustomData("PlayerDied", new Dictionary<string, object>
        {
            {"timeFromStartFloat", Time.timeSinceLevelLoad},
            {"positionCurrent", GameObject.Find("XR Origin").transform.position.ToString("F3")},
            {"deathReason", deathReason}
        });
        Debug.Log("timeFromStart: " + Time.timeSinceLevelLoad);
        Debug.Log("positionCurrent: " + GameObject.Find("XR Origin").transform.position);
        Debug.Log("deathReason: " + deathReason);
    }
}
