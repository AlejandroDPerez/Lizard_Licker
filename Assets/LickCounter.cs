using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LickCounter : MonoBehaviour
{


    public void onButtonClick(){
        GlobalLicks.lickCount += 1;

    
    }
    
}
