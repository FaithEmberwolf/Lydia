using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{

        

    // Start is called before the first frame update
    private void Start()
    {
        GameEvents.current.onChestTriggerBlocks += OnBlocksAppear;
    }

    // Update is called once per frame

    private void OnBlocksAppear()
    {
       gameObject.SetActive(true);
    }
}
