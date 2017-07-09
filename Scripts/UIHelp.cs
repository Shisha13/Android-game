using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIHelp : MonoBehaviour {

    public GameObject Menu;
    public GameObject Left;
    public GameObject Right;
    

    
   public void GamePause()
    {
        Menu.SetActive(true);
        Left.SetActive(false);
        Right.SetActive(false);
        Time.timeScale = 0;

    }

    public void Resume()
    {
        Menu.SetActive(false);
        Left.SetActive(true);
        Right.SetActive(true);
        Time.timeScale = 1;
    }
    public void StartGame()
    {
        Application.LoadLevel("Main");
        Time.timeScale = 1;
    }
    public void ExitGame()
    {
        Application.Quit();

    }

}
