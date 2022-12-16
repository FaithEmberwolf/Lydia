using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour
{
    public GameObject Cube;
    public GameObject CubeFive;
    public GameObject CubeFour;
    public GameObject CubeSix;
    public GameObject CubeThree;
    public GameObject CubeTwo;

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
               Cube.SetActive(true);
               CubeTwo.SetActive(true);
               CubeThree.SetActive(true);
               CubeFour.SetActive(true);
               CubeFive.SetActive(true);
               CubeSix.SetActive(true);
               
            }
        }
    }
        
    

