using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class daysCounter : MonoBehaviour
{
    private skyDomeDayNight skyDomeDayNight;
    public TextMeshProUGUI dayCounter;
 private int days;
   
    void Start()
    {
        Application.targetFrameRate = 60;
        skyDomeDayNight = FindObjectOfType(typeof(skyDomeDayNight)) as skyDomeDayNight;
    }

  
    void Update()

    {
       
        
        dayCounter.text = skyDomeDayNight.days.ToString("N0");
    }
}
