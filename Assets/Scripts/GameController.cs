using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public GameObject PopUpScreen;
    public TextMeshProUGUI pupUpHeadingHUD; 
    public TextMeshProUGUI popUpTextHUD;

    public string currentPopUpHeading;
    public string currentPopUpText;
   

    public void TurnOnPopUp(string popUpHeading, string popUpText)
    {
        currentPopUpHeading = popUpHeading;
        currentPopUpText = popUpText;
        PopUpScreen.SetActive(true);
    }

    public void TurnOffPopUp()
    {
        PopUpScreen.SetActive(false);
    }
   

    // Update is called once per frame
    void Update()
    {
        pupUpHeadingHUD.text = currentPopUpHeading;
        popUpTextHUD.text = currentPopUpText;
    }
}
