using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class popUpsystem : MonoBehaviour
{
    public GameObject popUpBox;
    public Animator animator; 
    public TextMeshProUGUI popUpText; 

    public void PopUp(string text)
    {

        popUpBox.SetActive(true);
        popUpText.text = text; 
        animator.SetTrigger("pop");
    }
}