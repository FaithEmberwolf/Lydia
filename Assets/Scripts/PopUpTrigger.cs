using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PopUpTrigger : MonoBehaviour
{
public GameController PopUpScreen;

public string customPupUpHeading;
public string customPopUpText;

void OnTriggerEnter(Collider other)
{
  if (other.gameObject.tag == "Player")
  {
      other.gameObject.GetComponent<GameController>().PopUpScreen(customPupUpHeading, customPopUpText);
  }
}
}