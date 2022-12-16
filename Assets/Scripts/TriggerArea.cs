using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{

    //This is more trouble than it's worth
    //internal screaming
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
        GameEvents.current.ChestTriggerBlocks();
        }
    }
}
