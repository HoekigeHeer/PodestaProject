﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {
    public Slider economicSlider;
    public Slider environmentSlider;
    public Slider cultureSlider;
    public Slider safetySlider;
    public Text billNameDisplay;

	// Use this for initialization
	void Start () {
        economicSlider.maxValue = Singleton.mySingleton.economyValueMax;
        economicSlider.minValue = Singleton.mySingleton.economyValueMin;
        environmentSlider.maxValue = Singleton.mySingleton.environmentValueMax;
        environmentSlider.minValue = Singleton.mySingleton.environmentValueMin;
        cultureSlider.maxValue = Singleton.mySingleton.culturalValueMax;
        cultureSlider.minValue = Singleton.mySingleton.culturalValueMin;
        safetySlider.maxValue = Singleton.mySingleton.safetyValueMax;
        safetySlider.minValue = Singleton.mySingleton.safetyValueMin;
	}
	
	// Update is called once per frame
	void Update () {
        economicSlider.value = Singleton.mySingleton.economyValue;
        environmentSlider.value = Singleton.mySingleton.environmentValue;
        cultureSlider.value = Singleton.mySingleton.culturalValue;
        safetySlider.value = Singleton.mySingleton.safetyValue;
        billNameDisplay.text = Singleton.mySingleton.myBills[Random.Range(0, Singleton.mySingleton.myBills.Count)].billName;
    }
}
