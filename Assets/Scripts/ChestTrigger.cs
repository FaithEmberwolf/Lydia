using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestTrigger : MonoBehaviour
{
 private void TriggerBlocks(Collider other)

{
    if(other.gameObject.tag == "Player")
    {
    NewEventBus.current.ChestTriggerBlocks();
    }
}
}
