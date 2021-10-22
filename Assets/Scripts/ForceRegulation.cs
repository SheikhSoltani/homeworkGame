using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForceRegulation : MonoBehaviour
{


    public Text forvardValue;
    public Slider forvardSlider;
    public Text sidewayValue;
    public Slider sidewaySlider;
    public PlayerMovement playerMovement;


    public void ForvardSliderChange()
    {

        forvardValue.text = playerMovement.forwardForce.ToString();

        playerMovement.forwardForce = forvardSlider.value;
    }
    public void SidewaySliderChange()
    {

        sidewayValue.text = playerMovement.sidewayForce.ToString();

        playerMovement.sidewayForce = sidewaySlider.value;
    }
}
