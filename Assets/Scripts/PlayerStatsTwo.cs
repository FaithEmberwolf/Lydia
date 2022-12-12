using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerStatsTwo : MonoBehaviour
{
    public WaterOxy oxygenBar;

    float oxygenValue = 100f;
    float oxygenMax = 100f;

    public bool drowning = false;
    public bool breathing = false; 
    // Start is called before the first frame update
   void Start()
    {
        oxygenBar.InitBar(oxygenMax);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (drowning == true)
        {
            takeDamage(0.05f);
        }
        
        if (breathing == true)
        {
            heal(0.05f);
        }
    }
    void takeDamage(float damage)
    {
        oxygenValue -= damage;

        oxygenBar.SetValue(oxygenValue);
    }
    
     public void heal(float healing) 
     {
        oxygenValue += healing;
        oxygenBar.SetValue(oxygenValue);
 
    }
}