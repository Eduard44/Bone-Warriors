using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    // the slider is used to adjust the health that we have both min and max
    public Slider slider;

    //this sets our max health
    public void SetMaxHealth(float health)
    {
        //making the slider have the max health and
        //of course the min health stays 0 so we don't need a function for it
        slider.maxValue = health;
        //this is so we start at max health
        slider.value = health;
    }
    //this function moves our slider which visually moves the values
    public void SetHealth(float health)
    {
        slider.value = health;
    }
}
