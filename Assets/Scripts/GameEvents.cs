using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current; 

    private void Awake()
    {
        current = this; 
    }

    public event Action onChestTriggerBlocks; 
    
    public void ChestTriggerBlocks()
    {
        if (onChestTriggerBlocks != null) 
        {
            onChestTriggerBlocks();
        }
    }
}
