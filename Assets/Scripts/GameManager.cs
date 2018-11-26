﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool GameHasEnded = false;
    public static bool testmode = false;
    public GameObject EndGameUI;


    public void EndGame()
    {
        GameHasEnded = true;
        Debug.Log("game over!");
        EndGameUI.SetActive(true);
    }
    public void Restart()
    {
        foreach (GameObject o in Object.FindObjectsOfType<GameObject>())
        {
            Destroy(o);
        }
        //EndGameUI.SetActive(false);

        SceneManager.LoadScene("Cover");

    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void FinishGame()
    {
        GameHasEnded = true;
        SceneManager.LoadScene("gamefinish");
    }
    public void TestModeOn()
    {
        testmode = true;
    }

    
      


}