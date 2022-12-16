using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    
   // Start is called before the first frame update
    void Start()
    {
       GameEvents.current.onChestTriggerBlocks += ChestTriggerBlocks;
    }

    // Update is called once per frame
    private void ChestTriggerBlocks()
    {
        {
             gameObject.SetActive(true);
               
            }
        }
    }
        
    

