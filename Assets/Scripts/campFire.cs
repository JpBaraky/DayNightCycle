using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class campFire : MonoBehaviour
{

    [Header("CampFire Settings")]

    private skyDomeDayNight skyDomeDayNight;
    public ParticleSystem.MainModule mainModule;


    public AudioSource campFireSound;
    public GameObject fire;
    void Start()
    {
        skyDomeDayNight = FindObjectOfType(typeof(skyDomeDayNight)) as skyDomeDayNight;
        mainModule = fire.GetComponent<ParticleSystem>().main;

    }


    void Update()
    {
        FirePit();
    }
    void FirePit()
    { // turns on and off the firepit
        if (skyDomeDayNight.offSet >= 0.7 || skyDomeDayNight.offSet <= 0.3)
        {
            mainModule.startSizeMultiplier = 1;
            campFireSound.UnPause();

        }
        else
        {
            campFireSound.Pause();
            mainModule.startSizeMultiplier = 0;
        }
    }
}
