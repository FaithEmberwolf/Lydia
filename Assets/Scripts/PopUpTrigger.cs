using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PopUpTrigger : MonoBehaviour
{
public GameObject gameController; 

public GameObject PopUpScreen;

public string customPupUpHeading;
public string customPopUpText;

void OnTriggerEnter(Collider other)
{
  if (other.gameObject.tag == "Player")
  {
      gameController.GetComponent<GameController>().TurnOnPopUp(customPupUpHeading, customPopUpText);
      gameObject.SetActive(false); 
      //gameObject.GetComponent<PlayerMovement>().SetActive(false);
  }
}

}