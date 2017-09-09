﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour 
{
    public void LoadLevel(string name) 
    {
        SceneManager.LoadScene(name);
    }

    public void LoadNextLevel() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Ne me quittes pas ...");
    }
	
    public void BrickDestroyed() 
    {
        if (Brick.breakableCount <= 0) 
        {
            LoadNextLevel();
        }
    }
        
}
