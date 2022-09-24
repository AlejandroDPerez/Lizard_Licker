using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class autoLickers : MonoBehaviour
{
    public static int numAutoLickers;
    public static float autoLickMultiplier;

    public static float autoLickCost;
    public static float autoLickUpgradeCost;
   
    public GameObject autoLickButton;
    public GameObject autoLickUpgradeButton;
   
   
   
    // Start is called before the first frame update
    void Start()
    {
        numAutoLickers = 0;
        autoLickMultiplier = 1;
        autoLickCost = Constants.autoLickBaseCost;
        autoLickUpgradeCost = Constants.autoLickUpgradeBaseCost;
    }

    // Update is called once per frame
    void Update()
    {
        autoLickButton.GetComponent<TMP_Text>().text = "Generate Auto Licker\nCost: " + autoLickCost + " licks";
        autoLickUpgradeButton.GetComponent<TMP_Text>().text = "Double AutoLicker Efficiency\nCost: " + autoLickUpgradeCost + " licks";
    }

    public void incrementAutoLickers(){
        if(GlobalLicks.lickCount >= autoLickCost){
            GlobalLicks.lickCount -= autoLickCost;
            numAutoLickers++;

            autoLickCost *= Constants.upgradeCostMult;
            autoLickCost = (float) Math.Floor(autoLickCost);

            GlobalUpgrades.updateLicksPerSecond();
            autoLickButton.GetComponent<TMP_Text>().text = "Generate Auto Licker\nCost: " + autoLickCost + " licks";
        }
        
    }

    public void multiplyAutoLickers(){
         if(GlobalLicks.lickCount >= autoLickUpgradeCost){
            GlobalLicks.lickCount -= autoLickUpgradeCost;
            autoLickMultiplier *= Constants.autoUpgradeValue;
            
            autoLickUpgradeCost *= Constants.upgradeCostMult;
            autoLickUpgradeCost = (float) Math.Floor(autoLickUpgradeCost);

            GlobalUpgrades.updateLicksPerSecond();
            autoLickUpgradeButton.GetComponent<TMP_Text>().text = "Double AutoLicker Efficiency\nCost: " + autoLickUpgradeCost + " licks";
         }
    }

}
