using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;


public class GlobalLicks : MonoBehaviour
{
    public static float lickCount;
    public static float licksPerSecond;
    
    public GameObject lickDisplay;
    public GameObject lpsDisplay;

    private int internalLick;
    private float internalLps;
    private float updateTime;

    void Start (){
        licksPerSecond = 0.0f;
        lickCount = 0.0f;
    }

    void Update (){
        updateTime += Time.deltaTime;


        if(updateTime >= 0.1f){
            updateTime = 0.0f;
            lickCount += (licksPerSecond / 20.0f);
        }

        internalLick = (int) Math.Floor(lickCount);
        internalLps = licksPerSecond;
        lickDisplay.GetComponent<TMP_Text>().text = "Licks: " + internalLick;
        if(licksPerSecond > 100){
            lpsDisplay.GetComponent<TMP_Text>().text = "Licks Per Second: " + Math.Floor(internalLps);
        }
        else lpsDisplay.GetComponent<TMP_Text>().text = "Licks Per Second: " + Math.Round(internalLps,2);

    }
}
