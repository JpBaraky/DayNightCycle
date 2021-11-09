using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class skyDomeDayNight : MonoBehaviour
{
    private Material material;
    
    [Header("Sky Assets Settings")] //Set the moon, starts and sun objects
    public GameObject Moon;
    public GameObject Stars;
    public GameObject Sun;
    [Header("Light Settings")] //Set the moon, starts and sun objects

    public Light Light;
    private float maxLight = 1.0f;
    private float minLight = 0.0f;
    static float t;
    [Header("Sky Movement Systems")]
    public float cycleSpeed; //Set how fast the night and day cycle will be by changing the offSet
     private float offSet; //Set how the Cycle will start
    void Start()
    {
        material = GetComponent<Renderer>().material; // Gets the material of the Sky
    
    }

  
    void Update()
    {
       CycleDay();
       MoonAndSun();
       SunLight();

    }
    void CycleDay(){ // Day and Night Cycle
         offSet += cycleSpeed * Time.deltaTime; 
        material.SetTextureOffset("_MainTex" , new Vector2(offSet, 0));   // Increase the offset of the object in a certain rate 
        if(offSet >= 1){
            offSet = 0;
        }
       
    }
    void MoonAndSun(){ 
        if(offSet >= 0.2 && offSet <= 0.7){
            Moon.SetActive(false);
            Stars.SetActive(false);
            Sun.SetActive(true);
        } 
        else{
             Moon.SetActive(true);
            Stars.SetActive(true);
            Sun.SetActive(false);
        }


    }   
    void SunLight(){ //Increase and Decrease the intensity of the light with the cycle

        
        Light.intensity = Mathf.Lerp(minLight, maxLight, t);
        t += cycleSpeed * Time.deltaTime * 2;
        if (t > 1.0f)
        {
            float temp = maxLight;
            maxLight = minLight;
            minLight = temp;
            t = 0.0f;
        }


    }
}
