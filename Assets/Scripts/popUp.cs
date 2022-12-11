using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popUp : MonoBehaviour
{
public GameManager GameController;

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
