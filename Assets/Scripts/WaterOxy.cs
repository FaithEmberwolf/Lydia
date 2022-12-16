using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterOxy : MonoBehaviour
{
   public Slider oxygenSlider;

    public void InitBar(float maxValue)
    {
        oxygenSlider.maxValue = maxValue;
        oxygenSlider.value = maxValue;
    }

    public void SetValue(float oxygenValue)
    {
        oxygenSlider.value = oxygenValue;
    }
}
