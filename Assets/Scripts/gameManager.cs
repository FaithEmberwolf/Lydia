using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gameManager : MonoBehaviour
{
public GameObject gameController;

public string customPopUpHeading;
public string customPopUpText;

void OnTriggerEnter(Collider other)
{
  if (other.gameObject.tag == "Player")
  {
      gameController.GetComponent<GameController>().TurnOnPopUp(customPopUpHeading, customPopUpText);
  }
}
}