using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class GlobalUpgrades : MonoBehaviour
{
   
    
    public static float lickMultiplier;
    
    public static float lickUpgradeCost;

    
    public GameObject lickUpgradeButton;
    


    // Start is called before the first frame update
    void Start(){
  
        lickMultiplier = 1;

        lickUpgradeCost = Constants.lickUpgradeBaseCost;



        
    }

    void Update(){
        lickUpgradeButton.GetComponent<TMP_Text>().text = "Upgrade Lick Value by " + Constants.lickUpgradeValue +"\nCost: " + lickUpgradeCost + " licks";
        
        
    }
    
    public static void updateLicksPerSecond(){
        



        GlobalLicks.licksPerSecond = autoLickers.numAutoLickers * Constants.autoLickerValue * autoLickers.autoLickMultiplier;

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
