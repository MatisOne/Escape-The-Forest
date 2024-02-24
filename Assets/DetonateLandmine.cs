using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetonateLandmine : MonoBehaviour
{
    public AudioSource playSound;
    public GameObject explosionAnim;

    void OnTriggerEnter(Collider other){
        playSound.Play();
        explosionAnim.SetActive(true);
    }
}
