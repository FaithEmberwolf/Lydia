using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class popUp : MonoBehaviour
{
public GameObject GameController;

public string customPopUpHeading;
public string customPopUpText;

void OnTriggerEnter(Collider other)
{
  if (other.gameObject.tag == "Player")
  {
      GameController.GetComponent<GameController>().TurnOnPopUp("title", "Text(TMP)");
  }
}
}
