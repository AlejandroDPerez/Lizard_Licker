using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constants : MonoBehaviour
{

   //GENERAL CONSTANTS
   public const float updateTime = 0.1f;


   //not a constant bc its a color but like were gonna use it as one just dont change it anywhere
   public Color inactiveButtonColor = new Color(0.4245283f, 0.4245283f, 0.4245283f, 1.0f);


   //UPGRADE CONSTANTS
   
   //costs
   public const float autoLickBaseCost = 15.0f;
   public const float lickWorkerBaseCost = 100.0f;
   public const float lickFactoryBaseCost = 1100.0f;

   public const float lickUpgradeBaseCost = 10.0f;
   public const float autoLickUpgradeBaseCost = 10.0f;
   public const float lickWorkerUpgradeBaseCost = 10.0f;
   public const float lickFactoryUpgradeBaseCost = 10.0f;

   public const float upgradeCostMult = 1.15f;

   //value
   public const float autoLickerValue = 0.1f;
   public const float lickWorkerValue = 2.0f;
   public const float lickFactoryValue = 8.0f;

   public const float lickUpgradeValue = 1.5f;
   public const float autoUpgradeValue = 2.0f;


   

  


   public const float testMultipliers = 1.5f;


}
