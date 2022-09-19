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


    private int internalLick;
    private float updateTime;

    void Start (){
        licksPerSecond = 0.0f;
        lickCount = 0.0f;
    }

    void Update (){
        updateTime += Time.deltaTime;

        //every tenth second
    
        if(updateTime > 0.1f){
            updateTime = 0.0f;
            lickCount += (licksPerSecond / 10.0f);
        }

        internalLick = (int) Math.Floor(lickCount);
        lickDisplay.GetComponent<TMP_Text>().text = "Licks: " + internalLick;
        

    }
}
