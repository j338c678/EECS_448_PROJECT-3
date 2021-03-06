﻿/** 
 * @author Team FourFour8
 * @file Stage4.cs
 * @date October 2018
 * @brief Stage4 class. This class takes charge of the properties of the Stage4.
**/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
* @pre None.
* @post Keep the GameObject Stage5 when change the scene because unity destroy eveything on current scene after change scenes.
* @para None.   
**/
public class Stage5 : MonoBehaviour {
    public void Awake()
    {
        DontDestroyOnLoad(this);

        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }
}
