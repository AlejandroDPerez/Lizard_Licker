using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class lickFactory : MonoBehaviour
{
    public static int numLickFactories;
    public static float lickFactoryMultiplier;

    public static float lickFactoryCost;
    public static float lickFactoryUpgradeCost;
   
    public GameObject lickFactoryButton;
    public GameObject lickFactoryUpgradeButton;
   
   
   
    // Start is called before the first frame update
    void Start()
    {
        numLickFactories = 0;
        lickFactoryMultiplier = 1;
        lickFactoryCost = Constants.lickFactoryBaseCost;
        lickFactoryUpgradeCost = Constants.lickFactoryUpgradeBaseCost;
    }

    // Update is called once per frame
    void Update()
    {
        lickFactoryButton.GetComponent<TMP_Text>().text = "Buy Lick Factory\nCost: " + lickFactoryCost + " licks";
        lickFactoryUpgradeButton.GetComponent<TMP_Text>().text = "Double Lick Factory Efficiency\nCost: " + lickFactoryUpgradeCost + " licks";
    }

    public void incrementLickFactories(){
        if(GlobalLicks.lickCount >= lickFactoryCost){
            GlobalLicks.lickCount -= lickFactoryCost;
            numLickFactories++;

            lickFactoryCost *= Constants.upgradeCostMult;
            lickFactoryCost = (float) Math.Floor(lickFactoryCost);

            GlobalUpgrades.updateLicksPerSecond();
            lickFactoryButton.GetComponent<TMP_Text>().text = "Hire Lick Factory\nCost: " + lickFactoryCost + " licks";
        }
        
    }

    public void multiplyLickFactories(){
         if(GlobalLicks.lickCount >= lickFactoryUpgradeCost){
            GlobalLicks.lickCount -= lickFactoryUpgradeCost;
            lickFactoryMultiplier *= Constants.autoUpgradeValue;
            
            lickFactoryUpgradeCost *= Constants.upgradeCostMult;
            lickFactoryUpgradeCost = (float) Math.Floor(lickFactoryUpgradeCost);

            GlobalUpgrades.updateLicksPerSecond();
            lickFactoryUpgradeButton.GetComponent<TMP_Text>().text = "Double Lick Factory Efficiency\nCost: " + lickFactoryUpgradeCost + " licks";
         }
    }

}
