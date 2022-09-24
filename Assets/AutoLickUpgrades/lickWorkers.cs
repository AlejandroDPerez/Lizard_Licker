using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class lickWorkers : MonoBehaviour
{
    public static int numLickWorkers;
    public static float lickWorkerMultiplier;

    public static float lickWorkerCost;
    public static float lickWorkerUpgradeCost;
   
    public GameObject lickWorkerButton;
    public GameObject lickWorkerUpgradeButton;
   
   
   
    // Start is called before the first frame update
    void Start()
    {
        numLickWorkers = 0;
        lickWorkerMultiplier = 1;
        lickWorkerCost = Constants.lickWorkerBaseCost;
        lickWorkerUpgradeCost = Constants.lickWorkerUpgradeBaseCost;
    }

    // Update is called once per frame
    void Update()
    {
        lickWorkerButton.GetComponent<TMP_Text>().text = "Hire Lick Worker\nCost: " + lickWorkerCost + " licks";
        lickWorkerUpgradeButton.GetComponent<TMP_Text>().text = "Double Lick Worker Efficiency\nCost: " + lickWorkerUpgradeCost + " licks";
    }

    public void incrementLickWorkers(){
        if(GlobalLicks.lickCount >= lickWorkerCost){
            GlobalLicks.lickCount -= lickWorkerCost;
            numLickWorkers++;

            lickWorkerCost *= Constants.upgradeCostMult;
            lickWorkerCost = (float) Math.Floor(lickWorkerCost);

            GlobalUpgrades.updateLicksPerSecond();
            lickWorkerButton.GetComponent<TMP_Text>().text = "Hire Lick Worker\nCost: " + lickWorkerCost + " licks";
        }
        
    }

    public void multiplyLickWorkers(){
         if(GlobalLicks.lickCount >= lickWorkerUpgradeCost){
            GlobalLicks.lickCount -= lickWorkerUpgradeCost;
            lickWorkerMultiplier *= Constants.autoUpgradeValue;
            
            lickWorkerUpgradeCost *= Constants.upgradeCostMult;
            lickWorkerUpgradeCost = (float) Math.Floor(lickWorkerUpgradeCost);

            GlobalUpgrades.updateLicksPerSecond();
            lickWorkerUpgradeButton.GetComponent<TMP_Text>().text = "Double Lick Worker Efficiency\nCost: " + lickWorkerUpgradeCost + " licks";
         }
    }

}
