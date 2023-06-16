using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartBtn()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void QuitBtn()
    {
        Application.Quit();
        Debug.Log("Player has quit the game");
    }

    public void MainMenuBtn()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void TPtoSpawnBtn()
    {
        CharacterController controller = GetComponent<CharacterController>();
        controller.transform.position = new Vector3(0f, 0f, 0f);
    }
}
