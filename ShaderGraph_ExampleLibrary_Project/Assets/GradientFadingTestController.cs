using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GradientFadingTestController : MonoBehaviour
{
    public Material materialFade;
    public Material materialDisolve;
    public Slider fadeSlider;
    public Slider disolveAmountSlider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gradientFadingChanged()
    {
        materialFade.SetFloat("Vector1_A235A670", fadeSlider.value);
    }

    public void disolveAmountChanged()
    {
        materialDisolve.SetFloat("Vector1_1A992A94", disolveAmountSlider.value);
    }
}
