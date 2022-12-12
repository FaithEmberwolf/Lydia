using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerStats : MonoBehaviour
{

    public HpBar hpBar;
    public WaterOxy oxygenBar;

    float hpValue = 100f;
    float hpMax = 100f; 
    float oxygenValue = 100f;
    float oxygenMax = 100f;

    public bool poisoned = false; 
    public bool gainhealth = false; 
    public bool drowning = false;
    public bool breathing = false; 
    // Start is called before the first frame update
    void Start()
    {
        hpBar.InitBar(hpMax);
        oxygenBar.InitBar(oxygenMax);

    }

    // Update is called once per frame
    void Update()
    {
        if (poisoned == true)
        {
            takeDamage(0.05f);
        }
        
        if (gainhealth == true)
        {
            heal(0.05f);
        }
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
        hpValue -= damage;

        hpBar.SetValue(hpValue);

        oxygenValue -= damage;

        oxygenBar.SetValue(oxygenValue);
    }
    
     public void heal(float healing) 
     {
        hpValue += healing;
        hpBar.SetValue(hpValue);
        
        oxygenValue += healing;
        oxygenBar.SetValue(oxygenValue);
 
    }
}

    

