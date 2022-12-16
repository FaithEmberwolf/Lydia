using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerStats : MonoBehaviour
{

    public HpBar hpBar;


    float hpValue = 100f;
    float hpMax = 100f; 


    public bool poisoned = false; 
    public bool gainhealth = false; 

    // Start is called before the first frame update
    void Start()
    {
        hpBar.InitBar(hpMax);
     

    }

    // Update is called once per frame
    void Update()
    {
        if (poisoned == true)
        {
            takeDamage(0.1f);
        }
        
        if (gainhealth == true)
        {
            heal(0.05f);
        }
      
         
         }

    void takeDamage(float damage)
    {
        hpValue -= damage;

        hpBar.SetValue(hpValue);

   
    }
    
     public void heal(float healing) 
     {
        hpValue += healing;
        hpBar.SetValue(hpValue);

 
    }
}

    

