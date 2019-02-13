using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScenarioUIController : MonoBehaviour
{
    public Material[] snowMataterials;
    public Slider snowCoverage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void snowCoverageChanged()
    {
        foreach(Material  m in snowMataterials)
        {
            m.SetFloat("Vector1_23336273", snowCoverage.value);
        }
    }

    
}
