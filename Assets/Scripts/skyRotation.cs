using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyRotation : MonoBehaviour
{
   public Vector3 rotationSpeed;
   private skyDomeDayNight skyDomeDayNight;
    void Start()
    {
       skyDomeDayNight = FindObjectOfType(typeof(skyDomeDayNight)) as skyDomeDayNight;
    }

   void FixedUpdate(){
          transform.Rotate(rotationSpeed * skyDomeDayNight.cycleSpeed); //Leave the rotation speed on 360 for better timing

   }
   
}
