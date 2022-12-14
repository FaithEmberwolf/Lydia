using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalRed : MonoBehaviour
{
    public GameObject BackpackObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            BackpackObject.GetComponent<Backpack>().redCrystalinBackpack = true;
            gameObject.SetActive(false);
        }
    }
}
