using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{

        public GameObject Cube;
        public GameObject CubeTwo;
        public GameObject CubeThree;
        public GameObject CubeFour;
        public GameObject CubeFive;
        public GameObject CubeSix;

    // Start is called before the first frame update
    private void Start()
    {
        GameEvents.current.onChestTriggerBlocks += OnBlocksAppear;
    }

    // Update is called once per frame

    private void OnBlocksAppear()
    {
        Cube.SetActive(true);
        CubeTwo.SetActive(true);
        CubeThree.SetActive(true);
        CubeFour.SetActive(true);
        CubeFive.SetActive(true);
        CubeSix.SetActive(true);
    }
}
