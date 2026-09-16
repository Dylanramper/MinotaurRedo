using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool paused;
    
    private void Start()
    {
        paused = false;
    }

    private void Update()
    {
        if(paused == true)
        {
            Time.timeScale = 0;
        }
    }

    public void pauseGame()
    {
        paused = true;
    }

    public void playGame()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
}
