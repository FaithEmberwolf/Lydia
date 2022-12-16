using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using System; 


public class NewEventBus : MonoBehaviour
{

    public static NewEventBus current; 

    private void Awake()
    {
        current = this; 
    }
    
    public event Action onChestTriggerBlocks;
    public void ChestTriggerBlocks()
    {
        if(onChestTriggerBlocks!=null)
        {
            onChestTriggerBlocks();
        }
    }
}
