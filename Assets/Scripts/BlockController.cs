using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    
    bool redCrystalinBackpack;
    // Start is called before the first frame update
    void Start()
    {
       NewEventBus.current.onChestTriggerBlocks += ChestTriggerBlocks;
    }

    // Update is called once per frame
    private void ChestTriggerBlocks()
    {
        {
             gameObject.SetActive(true);
               
            }
        }
    }
        
    

