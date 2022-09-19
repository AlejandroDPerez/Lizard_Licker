using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LickCounter : MonoBehaviour
{


    public void onButtonClick(){
        GlobalLicks.lickCount += (GlobalUpgrades.lickMultiplier);


    
    }
    
}
