using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioItemNavigator : MonoBehaviour
{
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = Vector3.zero + Camera.main.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Camera.main.transform.position += new Vector3(-10,0,0);
            if (Camera.main.transform.position.x < -40)
                Camera.main.transform.position = Vector3.zero + startPos;
        }
    }
}
