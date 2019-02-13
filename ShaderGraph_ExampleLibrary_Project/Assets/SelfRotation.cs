using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfRotation : MonoBehaviour
{
    public float rotationSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = Time.deltaTime * rotationSpeed;
        transform.Rotate(0, angle, 0, Space.World);
    }
}
