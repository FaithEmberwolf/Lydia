using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healingScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
     void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<playerStats>().heal(50f);
            gameObject.SetActive(false);
        }
    }
}