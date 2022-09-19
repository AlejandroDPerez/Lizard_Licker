using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalLicks : MonoBehaviour
{
    public static int lickCount;
    public GameObject lickDisplay;
    public int internalLick;
    void Update (){
        internalLick = lickCount;
        lickDisplay.GetComponent<TMP_Text>().text = "Licks: " + internalLick;

    }
}
