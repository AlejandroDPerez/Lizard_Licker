using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalUpgrades : MonoBehaviour
{
    public static int numAutoLickers;
    public static int autoMultiplier;
    public static int lickMultiplier;

    public GameObject lpsDisplay;


    // Start is called before the first frame update
    void Start(){
        numAutoLickers = 0;
        autoMultiplier = 1;
        lickMultiplier = 1;
    }

    void Update(){
        lpsDisplay.GetComponent<TMP_Text>().text = "Licks Per Second: " + GlobalLicks.licksPerSecond;
    }
    public void updateLicksPerSecond(){
        GlobalLicks.licksPerSecond = numAutoLickers * autoMultiplier;

    }

    public void incrementAutoLickers(){
        numAutoLickers++;
        updateLicksPerSecond();
    }

    public void multiplyAutos(){
        autoMultiplier *= 2;
        updateLicksPerSecond();
    }

    public void multiplyLicks(){
        lickMultiplier *= 2;
    }

}
