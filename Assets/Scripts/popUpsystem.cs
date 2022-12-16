using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popUpsystem : MonoBehaviour
{
    public GameObject popUpBox;
    public Animator animator; 
    public TMPro popUpText; 

    public void PopUp(string text)
    {

        popUpBox.SetActive(true);
        pupUpText.text = text; 
        animator.SetTrigger("pop");
    }
}