using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Services.Analytics;

public class youdied : MonoBehaviour
{
    public string deathReason = "undefinied";

    void OnTriggerEnter(Collider collider){
        if (collider.transform.CompareTag("Player")){
            StartCoroutine(die());
        }
    }

    IEnumerator die(){
        if(deathReason == "landmine"){
            Debug.Log("waiting fo landmine to explode");
            yield return new WaitForSeconds(4);
        }
        SceneManager.LoadScene("Death");
        Debug.Log("Player died");
        Unity.Services.Analytics.CustomEvent PlayerDied = new Unity.Services.Analytics.CustomEvent("PlayerDied");
        
            PlayerDied.Add("timeFromStartFloat", Time.timeSinceLevelLoad);
            PlayerDied.Add("positionCurrent", GameObject.Find("XR Origin").transform.position.ToString("F3"));
            PlayerDied.Add("howFarFromCenterFloat", Vector3.Distance(GameObject.Find("XR Origin").transform.position, Vector3.zero));
            PlayerDied.Add("deathReason", deathReason);
        

        // Wysyłanie zdarzenia z parametrami
        AnalyticsService.Instance.RecordEvent(PlayerDied);
        Debug.Log("timeFromStart: " + Time.timeSinceLevelLoad);
        Debug.Log("positionCurrent: " + GameObject.Find("XR Origin").transform.position);
        Debug.Log("howFarFromCenterFloat: " + Vector3.Distance(GameObject.Find("XR Origin").transform.position, Vector3.zero));
        Debug.Log("deathReason: " + deathReason);
    }
}
