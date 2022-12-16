using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{

        public GameObject Appear;
        public GameObject AppearTwo;
        public GameObject AppearThree;

    // Start is called before the first frame update
    private void Start()
    {
        GameEvents.current.onChestTriggerBlocks += OnBlocksAppear;
    }

    // Update is called once per frame

    private void OnBlocksAppear()
    {
       Appear.SetActive(true);
       AppearTwo.SetActive(true);
       AppearThree.SetActive(true);
       
    }
}
