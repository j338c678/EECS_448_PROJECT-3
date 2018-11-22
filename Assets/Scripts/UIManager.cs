﻿/** 
 * @author Team FourFour8
 * @file UIManager.cs
 * @date October 2018
 * @brief Stage5 class. This class takes charge of the properties of the UI.
**/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    public Slider GPABar;
    public Text GPAText;
    public Slider HealthBar;
    public Text HealthText;
    //public GPAManager GPA;
    public float gpatext;
    // Use this for initialization
    /**
    * @pre Valid PlayerManager.GPA.
    * @post Set the defalt value of the slider to current GPA.
    * @para None.
    **/
    void Start () {
        GPABar.value = PlayerManager.GPA;
        HealthBar.value = PlayerManager.Health;
    }
	/**
    * @pre Valid PlayerManager.GPA.
    * @post Update the slider's value.
    * @para None.
    **/
	void Update () {
        GPABar.maxValue = 1;
        GPABar.value = PlayerManager.GPA;
        float GPAString = PlayerManager.GPA * 4;
        HealthBar.maxValue = 1;
        HealthBar.value = PlayerManager.Health;
        float HealthString = PlayerManager.Health;
        HealthText.text = "Health:"+HealthString.ToString("0")+"/100";
        GPAText.text = "GPA:"+GPAString.ToString("0.00")+"/4.00";

	}
}
