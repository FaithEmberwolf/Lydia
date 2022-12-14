using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oxygenLoss : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

     void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerStatsTwo>().drowning = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerStatsTwo>().drowning = false;
            other.gameObject.GetComponent<PlayerStatsTwo>().breathing = true;
        }
    }
}