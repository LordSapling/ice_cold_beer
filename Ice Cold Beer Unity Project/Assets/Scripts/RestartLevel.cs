using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && GameOver.IsGameOver)
        {
            GameOver.IsGameOver = false;
            // This depends on your scene being named exactly "Game Scene" case sensitive
            SceneManager.LoadScene("SampleScene");
        }
    }
}