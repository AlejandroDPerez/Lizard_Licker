using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class GlobalUpgrades : MonoBehaviour
{
    public static int numAutoLickers;
    public static float autoMultiplier;
    public static float lickMultiplier;
    public static float autoOneCost;
    public static float autoUpgradeCost;
    public static float lickUpgradeCost;

    
    public GameObject lickUpgradeButton;
    public GameObject autoLickButton;
    public GameObject autoUpgradeButton;


    // Start is called before the first frame update
    void Start(){
        numAutoLickers = 0;
        autoMultiplier = 1;
        lickMultiplier = 1;
        autoOneCost = Constants.autoOneBaseCost;
        autoUpgradeCost = Constants.autoUpgradeBaseCost;
        lickUpgradeCost = Constants.lickUpgradeBaseCost;



        
    }

    void Update(){
        lickUpgradeButton.GetComponent<TMP_Text>().text = "Upgrade Lick Value by " + Constants.lickUpgradeValue +"\nCost: " + lickUpgradeCost + " licks";
        autoLickButton.GetComponent<TMP_Text>().text = "Generate Auto Licker\nCost: " + autoOneCost + " licks";
        autoUpgradeButton.GetComponent<TMP_Text>().text = "Upgrade Auto Licker Value by " + Constants.autoUpgradeValue +"\nCost: " + autoUpgradeCost + " licks";
        
    }
    
    public void updateLicksPerSecond(){
        GlobalLicks.licksPerSecond = numAutoLickers * Constants.autoLickerValue * autoMultiplier;

    }

    public void incrementAutoLickers(){
        if(GlobalLicks.lickCount >= autoOneCost){
            GlobalLicks.lickCount -= autoOneCost;
            numAutoLickers++;

            autoOneCost *= Constants.upgradeCostMult;
            autoOneCost = (float) Math.Floor(autoOneCost);

            updateLicksPerSecond();
            autoLickButton.GetComponent<TMP_Text>().text = "Generate Auto Licker\nCost: " + autoOneCost + " licks";
        }
        
    }

    public void multiplyAutos(){
         if(GlobalLicks.lickCount >= autoUpgradeCost){
            GlobalLicks.lickCount -= autoUpgradeCost;
            autoMultiplier *= Constants.autoUpgradeValue;
            
            autoUpgradeCost *= Constants.upgradeCostMult;
            autoUpgradeCost = (float) Math.Floor(autoUpgradeCost);

            updateLicksPerSecond();
            autoUpgradeButton.GetComponent<TMP_Text>().text = "Upgrade Auto Licker Value by " + Constants.autoUpgradeValue +"\nCost: " + autoUpgradeCost + " licks";
         }
        
    }

    public void multiplyLicks(){
         if(GlobalLicks.lickCount >= lickUpgradeCost){
            GlobalLicks.lickCount -= lickUpgradeCost;
            lickMultiplier *= Constants.lickUpgradeValue;
            
            lickUpgradeCost *= Constants.upgradeCostMult;
            lickUpgradeCost = (float) Math.Floor(lickUpgradeCost);

            updateLicksPerSecond();
            lickUpgradeButton.GetComponent<TMP_Text>().text = "Upgrade Lick Value by " + Constants.lickUpgradeValue +"\nCost: " + lickUpgradeCost + " licks";
         }
    }

}
