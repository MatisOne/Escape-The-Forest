using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class youwin : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        SceneManager.LoadScene("Success");
    }
}
