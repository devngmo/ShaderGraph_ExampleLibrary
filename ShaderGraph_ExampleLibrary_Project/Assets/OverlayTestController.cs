using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverlayTestController : MonoBehaviour
{
    public Material material;
    public Slider alphaSlider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void alphaChanged()
    {
        material.SetFloat("Vector1_49E847C7", alphaSlider.value);
    }
}
